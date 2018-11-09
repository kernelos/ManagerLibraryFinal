using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace Services.TableEntities
{
    /// <summary>
    /// Manipulate on Publisher Table
    /// </summary>
    public static class PublisherTableManipulation
    {

        /// <summary>
        /// This method is use to add an Publisher object to database
        /// </summary>
        /// <param name="publisher">Object to add to database</param>
        /// <exception cref="ArgumentNullException">If publisher params is null</exception>
        public static void Add(Publisher publisher)
        {
            if (publisher == null)
            {
                throw new ArgumentNullException("publisher is null");
            }
            using (var database = new LibraryManagementEntities())
            {
                Publisher existPublisher = database.Publishers.FirstOrDefault(a => a.PublisherName == publisher.PublisherName);
                if (existPublisher == null)
                {
                    database.Publishers.Add(publisher);
                    database.SaveChanges();
                }
            }
        }

        /// <summary>
        /// This method is used to remove an Publisher from the database
        /// </summary>
        /// <param name="publisher"></param>
        /// <exception cref="ArgumentNullException">If the Publisher object is null</exception>
        public static void Remove(Publisher publisher)
        {
            if (publisher == null)
            {
                throw new ArgumentNullException("Publisher is null");
            }
            using (var database = new LibraryManagementEntities())
            {
                Publisher deletedPublisher = database.Publishers.SingleOrDefault(a => a.PublisherName == publisher.PublisherName);
                if (deletedPublisher != null)
                {
                    database.Publishers.Remove(deletedPublisher);
                    database.SaveChanges();
                }
            }
        }


        /// <summary>
        /// Get all Publisher in database if correct the predicate 
        /// </summary>
        /// <param name="predicate">Publisher's condition</param>
        /// <returns>Publisher list object</returns>
        /// <exception cref="ArgumentNullException">if predicate is null</exception>
        public static List<Publisher> GetPublishersByCondition(Predicate<Publisher> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException();
            }
            List<Publisher> result = null;
            using (var database = new LibraryManagementEntities())
            {
                result = database.Publishers.ToList().Where(p => predicate(p)).ToList();
            }
            return result;
        }

        /// <summary>
        /// Update publisher's record in database
        /// </summary>
        /// <param name="oldName"></param>
        /// <param name="newName"></param>
        /// <exception cref="ArgumentException">if params is null</exception>
        /// <exception cref="InvalidOperationException">if oldName isn't a name of publisher in database
        /// or newName exist in database</exception>
        public static void UpdatePublisherRecord(string oldName, string newName)
        {
            if (oldName == null || newName == null)
            {
                throw new ArgumentNullException();
            }
            using (var database = new LibraryManagementEntities())
            {
                Publisher changedPublisher = database.Publishers.FirstOrDefault(a => a.PublisherName == oldName);
                if (changedPublisher == null)
                {
                    throw new InvalidOperationException();
                }
                Publisher newPublisher = database.Publishers.FirstOrDefault(a => a.PublisherName == newName);
                if (newPublisher != null)
                {
                    throw new InvalidOperationException();
                }
                changedPublisher.PublisherName = newName;
                database.SaveChanges();
            }
        }

        /// <summary>
        /// Return list book of an Publisher
        /// </summary>
        /// <param name="publisherName"></param>
        /// <returns>Book list of this Publisher</returns>
        public static List<Book> GetAllBook(string publisherName)
        {
            if (publisherName == null)
            {
                throw new ArgumentNullException("Publisher name is null");
            }
            using (var database = new LibraryManagementEntities())
            {
                Publisher publisher = database.Publishers.FirstOrDefault(a => a.PublisherName == publisherName);
                if (publisher != null)
                {
                    return publisher.Books.ToList();
                }
            }
            return null;
        }

        /// <summary>
        /// Get id of a publisher
        /// </summary>
        /// <param name="publisherName"></param>
        /// <exception cref="ArgumentNullException">if params is null</exception>
        /// <exception cref="InvalidOperationException">if publisherName is invalid</exception>
        /// <returns></returns>
        public static int GetId(string publisherName)
        {
            if (publisherName == null)
            {
                throw new ArgumentNullException();
            }
            using(var db = new LibraryManagementEntities())
            {
                Publisher publisher = db.Publishers.FirstOrDefault(p => p.PublisherName == publisherName);
                if(publisher == null)
                {
                    throw new InvalidOperationException();
                }
                return publisher.Id;
            }
        }
    }
}