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