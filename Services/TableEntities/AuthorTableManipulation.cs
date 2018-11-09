using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using System.Linq.Expressions;

namespace Services.TableEntities
{
    /// <summary>
    /// This class is used to manipulate the Author table
    /// static class
    /// </summary>
    public static class AuthorTableManipulation
    {
        /// <summary>
        /// This method is use to add an Author object to database
        /// </summary>
        /// <param name="author">Object to add to database</param>
        /// <exception cref="ArgumentNullException">If author params is null</exception>
        public static void Add(Author author)
        {
            if (author == null)
            {
                throw new ArgumentNullException("Author is null");
            }
            using (var database = new LibraryManagementEntities())
            {
                Author existAuthor = database.Authors.FirstOrDefault(a => a.AuthorName == author.AuthorName);
                if (existAuthor == null)
                {
                    database.Authors.Add(author);
                    database.SaveChanges();
                }
            }
        }

        /// <summary>
        /// This method is used to remove an author from the database
        /// </summary>
        /// <param name="author"></param>
        /// <exception cref="ArgumentNullException">If the author object is null</exception>
        public static void Remove(Author author)
        {
            if (author == null)
            {
                throw new ArgumentNullException("author is null");
            }
            using (var database = new LibraryManagementEntities())
            {
                Author deletedAuthor = database.Authors.SingleOrDefault(a => a.AuthorName == author.AuthorName);
                if (deletedAuthor != null)
                {
                    database.Authors.Remove(deletedAuthor);
                    database.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Get all author in database if correct the predicate 
        /// </summary>
        /// <param name="predicate">Author's condition</param>
        /// <returns>Author list object</returns>
        public static List<Author> GetAuthorsByCondition(Predicate<Author> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException();
            }
            List<Author> result;
            using(var db = new LibraryManagementEntities())
            {
                result = db.Authors.ToList().Where(a => predicate(a)).ToList();
            }
            return result;
        }

        /// <summary>
        /// Update author's record in database
        /// </summary>
        /// <param name="oldName"></param>
        /// <param name="newName"></param>
        /// <exception cref="ArgumentException">if params is null</exception>
        /// <exception cref="InvalidOperationException">if oldName isn't a name of author in database
        /// or newName exist in database</exception>
        public static void UpdateAuthorRecord(string oldName, string newName)
        {
            if (oldName == null || newName == null)
            {
                throw new ArgumentNullException();
            }
            using (var database = new LibraryManagementEntities())
            {
                Author changedAuthor = database.Authors.FirstOrDefault(a => a.AuthorName == oldName);
                if (changedAuthor == null)
                {
                    throw new InvalidOperationException();
                }
                Author newAuthor = database.Authors.FirstOrDefault(a => a.AuthorName == newName);
                if (newAuthor != null)
                {
                    throw new InvalidOperationException();
                }
                changedAuthor.AuthorName = newName;
                database.SaveChanges();
            }
        }

        /// <summary>
        /// Return list book of an author
        /// </summary>
        /// <param name="authorName"></param>
        /// <returns>Book list of this author</returns>
        public static List<Book> GetAllBook(string authorName)
        {
            if (authorName == null)
            {
                throw new ArgumentNullException("author name is null");
            }
            using (var database = new LibraryManagementEntities())
            {
                Author author = database.Authors.FirstOrDefault(a => a.AuthorName == authorName);
                if (author != null)
                {
                    List<Book> result = author.Books.ToList();
                    return result;
                }
            }
            return null;
        }

        /// <summary>
        /// Get id of a Author
        /// </summary>
        /// <param name="authorName"></param>
        /// <exception cref="ArgumentNullException">if params is null</exception>
        /// <exception cref="InvalidOperationException">if AuthorName is invalid</exception>
        /// <returns></returns>
        public static int GetId(string authorName)
        {
            if (authorName == null)
            {
                throw new ArgumentNullException();
            }
            using (var db = new LibraryManagementEntities())
            {
                Author author = db.Authors.FirstOrDefault(p => p.AuthorName == authorName);
                if (author == null)
                {
                    throw new InvalidOperationException();
                }
                return author.Id;
            }
        }
    }
}
