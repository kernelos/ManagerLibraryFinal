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
        /// Update author's record in database
        /// </summary>
        /// <param name="oldName"></param>
        /// <param name="newName"></param>
        /// <exception cref="ArgumentException">if params is null</exception>
        /// <exception cref="InvalidOperationException">if oldName isn't a name of author in database
        /// or newName exist in database</exception>
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
