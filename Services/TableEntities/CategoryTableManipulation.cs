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
