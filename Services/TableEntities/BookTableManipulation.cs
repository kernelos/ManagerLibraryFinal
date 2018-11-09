using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using Services.TableEntities;

namespace Services.TableEntities
{
    /// <summary>
    /// This class contains static method to manipulate on Book table
    /// </summary>
    public static class BookTableManipulation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="quantity"></param>
        /// <param name="isbn"></param>
        /// <param name="publishedYear"></param>
        /// <param name="description"></param>
        /// <param name="authorName"></param>
        /// <param name="publisherName"></param>
        /// <param name="category"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void AddBook(string title,
            int quantity,
            string isbn = null,
            int publishedYear = -1,
            string description = null,
            string authorName = null,
            string publisherName = null,
            string category = null)
        {
            if (title == null)
            {
                throw new InvalidOperationException();
            }
            Book b = new Book()
            {
                Title = title,
                Quantity = quantity
            };
            if (publishedYear != -1)
            {
                b.PublishedYear = publishedYear;
            }
            if (isbn != null)
            {
                b.ISBN = isbn;
            }
            if (publisherName != null)
            {
                PublisherTableManipulation.Add(new Publisher() { PublisherName = publisherName });
                int publisherId = PublisherTableManipulation.GetId(publisherName);
                b.PublisherId = publisherId;
            }
            if (category != null)
            {
                CategoryTableManipulation.Add(new Category() { CategoryName = category });
                int categoryId = CategoryTableManipulation.GetId(category);
                b.CategoryId = categoryId;
            }
            if (authorName != null)
            {
                AuthorTableManipulation.Add(new Author() { AuthorName = authorName });
                int authorId = AuthorTableManipulation.GetId(authorName);
                b.AuthorId = authorId;
            }
            using (var db = new LibraryManagementEntities())
            {
                db.Books.Add(b);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Remove book in database
        /// </summary>
        /// <param name="bookId">id of deleted book</param>
        /// <exception cref="InvalidOperationException">bookId is invalid</exception>
        public static void Remove(int bookId)
        {
            using (var db = new LibraryManagementEntities())
            {
                Book deletedBook = db.Books.FirstOrDefault(b => b.Id == bookId);
                if (deletedBook == null)
                {
                    throw new InvalidOperationException();
                }
                db.Books.Remove(deletedBook);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Update book record
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="newBook"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public static void UpdateBookRecord(int bookId, Book newBook)
        {
            using (var db = new LibraryManagementEntities())
            {
                Book changedBook = db.Books.FirstOrDefault(b => b.Id == bookId);
                if (changedBook == null)
                {
                    throw new InvalidOperationException();
                }
                changedBook.AuthorId = newBook.AuthorId;
                changedBook.BookDecription = newBook.BookDecription;
                changedBook.CategoryId = newBook.CategoryId;
                changedBook.Title = newBook.Title;
                changedBook.PublisherId = newBook.PublisherId;
                changedBook.PublishedYear = newBook.PublishedYear;
                changedBook.ISBN = newBook.ISBN;
                changedBook.Quantity = newBook.Quantity;
                db.SaveChanges();
            }
        }
        
        /// <summary>
        /// Get book by condition
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>Book's list object</returns>
        /// <exception cref="ArgumentException"></exception>
        public static List<Book> GetBookByCondition(Predicate<Book> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException();
            }
            using (var db = new LibraryManagementEntities())
            {
                return db.Books.ToList().Where(b => predicate(b)).ToList();
            }
        }
    }
}
