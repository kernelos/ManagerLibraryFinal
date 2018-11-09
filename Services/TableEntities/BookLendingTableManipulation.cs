using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
namespace Services.TableEntities
{
    /// <summary>
    /// Manipulate on LendingTable
    /// </summary>
    public static class BookLendingTableManipulation
    {
        /// <summary>
        /// Add record to lending table
        /// </summary>
        /// <param name="newLending"></param>
        public static void Add(BookLending newLending)
        {
            using (var db = new LibraryManagementEntities())
            {
                var query = from bookLending in db.BookLendings
                            where bookLending.StudentId == newLending.StudentId && bookLending.IsReturn == false
                            select bookLending;
                if (query.Count() > 0)
                {
                    throw new InvalidOperationException();
                }
                Book bookOne = db.Books.FirstOrDefault(x => x.Id == newLending.BooIdOne);
                bookOne.Quantity = bookOne.Quantity - 1;
                if (newLending.BookIdTwo != null)
                {
                    Book bookTwo= db.Books.FirstOrDefault(x => x.Id == newLending.BookIdTwo);
                    bookTwo.Quantity = bookTwo.Quantity - 1;
                }
                db.BookLendings.Add(newLending);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="innerStudentId"></param>
        /// <param name="libManagerId"></param>
        public static void ReturnBook(int innerStudentId, int libManagerId)
        {
            using (var db = new LibraryManagementEntities())
            {
                BookLending bookLending = db.BookLendings
                                            .FirstOrDefault(b => b.StudentId == innerStudentId && b.IsReturn == false);
                if (bookLending == null)
                {
                    throw new InvalidOperationException();
                }
                bookLending.ReturnManagerId = libManagerId;
                bookLending.IsReturn = true;
                bookLending.Book.Quantity++;
                bookLending.ReturnDay = DateTime.Today.Date;
                if (bookLending.BookIdTwo != null)
                {
                    bookLending.Book1.Quantity++;
                }
                db.SaveChanges();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="innerStudentId"></param>
        /// <param name="libManagerId"></param>
        public static void RenewBook(int innerStudentId, int libManagerId)
        {
            using (var db = new LibraryManagementEntities())
            {
                BookLending bookLending = db.BookLendings
                                            .FirstOrDefault(b => b.StudentId == innerStudentId && b.IsReturn == false);
                if (bookLending == null)
                {
                    throw new InvalidOperationException();
                }
                DateTime reNew = (DateTime)bookLending.LendingDay;
                reNew = reNew.AddDays(14);
                bookLending.LendingDay = reNew.Date;
                db.SaveChanges();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public static List<BookLending> GetBookLendingRecordByCondition(Predicate<BookLending> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException();
            }
            using (var db = new LibraryManagementEntities())
            {
                return db.BookLendings.ToList().Where(bl=>predicate(bl)).ToList();
            }
        }
    }
}
