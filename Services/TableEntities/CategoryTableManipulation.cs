using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace Services.TableEntities
{
    /// <summary>
    /// This class to manipulate on Category table
    /// </summary>
    public static class CategoryTableManipulation
    {
        /// <summary>
        /// Add category to database
        /// </summary>
        /// <param name="newCategory"></param>
        /// <exception cref="ArgumentNullException">If newCategory is null</exception>
        public static void Add(Category newCategory)
        {
            if (newCategory == null)
            {
                throw new ArgumentNullException();
            }
            using (var db = new LibraryManagementEntities())
            {
                Category category = db.Categories.FirstOrDefault(c => c.CategoryName == newCategory.CategoryName);
                if (category == null)
                {
                    db.Categories.Add(newCategory);
                    db.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Remove a category from Category table
        /// </summary>
        /// <param name="category"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void Remove(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException();
            }
            using (var db = new LibraryManagementEntities())
            {
                Category deletedCategory = db.Categories.FirstOrDefault(c => c.CategoryName == category.CategoryName);
                if (deletedCategory != null)
                {
                    db.Categories.Remove(deletedCategory);
                    db.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Update a category in database
        /// </summary>
        /// <param name="oldName"></param>
        /// <param name="newName"></param>
        /// <exception cref="ArgumentNullException">If params is null</exception>
        /// <exception cref="InvalidOperationException">If oldName is not in db or newName is exist in db</exception>
        public static void UpdateCategoryName(string oldName, string newName)
        {
            if (oldName == null || newName == null)
            {
                throw new ArgumentNullException();
            }
            using (var db = new LibraryManagementEntities())
            {
                Category changedCategory = db.Categories.FirstOrDefault(c => c.CategoryName == oldName);
                if (changedCategory == null)
                {
                    throw new InvalidOperationException($"Category {oldName} does not exist in db");
                }
                if (db.Categories.FirstOrDefault(c => c.CategoryName == newName) != null)
                {
                    throw new InvalidOperationException($"Category {newName} exist in db");
                }
                changedCategory.CategoryName = newName;
                db.SaveChanges();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>List of Category correct the predicate</returns>
        public static List<Category> GetCategoryByCondition(Predicate<Category> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException();
            }
            using (var db = new LibraryManagementEntities())
            {
                return db.Categories.ToList().Where(c => predicate(c)).ToList();   
            }
        }

        /// <summary>
        /// GetBookByCategory
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        public static List<Book> GetBookByCategory(string categoryName)
        {
            if (categoryName == null)
            {
                throw new ArgumentNullException();
            }
            using (var db = new LibraryManagementEntities())
            {
                Category category = db.Categories.FirstOrDefault(c => c.CategoryName == categoryName);
                if (category != null)
                {
                    var query = from book in category.Books
                                select book;
                    return query.ToList();
                }
            }
            return null;
        }

        /// <summary>
        /// Get id of a Category
        /// </summary>
        /// <param name="categoryName"></param>
        /// <exception cref="ArgumentNullException">if params is null</exception>
        /// <exception cref="InvalidOperationException">if CategoryName is invalid</exception>
        /// <returns></returns>
        public static int GetId(string categoryName)
        {
            if (categoryName == null)
            {
                throw new ArgumentNullException();
            }
            using (var db = new LibraryManagementEntities())
            {
                Category category = db.Categories.FirstOrDefault(p => p.CategoryName == categoryName);
                if (category == null)
                {
                    throw new InvalidOperationException();
                }
                return category.Id;
            }
        }
    }
}
