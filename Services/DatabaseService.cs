using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using Services.Entities;
using DevOne.Security.Cryptography.BCrypt;
using Services.TableEntities;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
namespace Services
{
    /// <summary>
    /// Class DatabaseService cung cấp phương thức thao tác dữ liệu trên database
    /// </summary>
    public class DatabaseService
    {
        #region Entity
        public ManagerEntitySet ManagerEntity { get; private set; }
        public StudentEntitySet StudentEntity { get; private set; }
        #endregion

        #region Constructer & private Function

        /// <summary>
        /// Hàm này để lưu trữu username của thủ thư đang đăng nhập để xác thực một số hoạt động
        /// Hàm này bắt buộc phải được gọi khi thủ thư đăng nhập
        /// </summary>
        /// <param name="usename">Tên Đăng nhập của thủ thư</param>
        public DatabaseService(string usename)
        {
            ManagerEntity = new ManagerEntitySet(usename);
            StudentEntity = new StudentEntitySet(usename);
        }

        /// <summary>
        /// Hàm trợ giúp thao tác trực tiếp trên database
        /// </summary>
        /// <returns>Trả về datatabase dưới dạng LibraryManagementEntities(object)</returns>
        public LibraryManagementEntities getDataContext()
        {
            var dataContext = new LibraryManagementEntities();
            dataContext.Database.CreateIfNotExists();
            return dataContext;
        }
        #endregion

        #region Login Service

        /// <summary>
        /// Hàm xác thực đăng nhập của Thủ Thư, thực hiện truy vấn và xác thực tính đúng
        /// đắng của username và password trong database.
        /// Chức năng mở rộng của hàm là tạo tài khoản mới có username, và passwork là "admin"
        /// nếu đây là lần đăng nhập của thủ thư đầu tiên (database chưa chứa dữ liệu gì về thủ thư)
        /// </summary>
        /// <param name="username">Tên đăng nhập của Thủ Thư</param>
        /// <param name="password">Password của Thủ Thư</param>
        /// <returns>Trả về giá trị boolean true hoặc false</returns>

        public bool Authenticate(string username, string password, Role role)
        {
            try
            {   //Trường hợp cho thủ thư
                if (role == Role.ManagerRole)
                {
                    if (IsFirstLoginManager())
                    {
                        ManagerEntity.Add(new DB.LibManager()
                        {
                            ManagerName = "admin",
                            PasswordStr = password,
                            Username = username
                        }
                        );
                        return true;
                    }
                    using (var dataContext = getDataContext())
                    {
                        var user = dataContext.LibManagers.FirstOrDefault(x => x.Username == username);
                        if (BCryptHelper.CheckPassword(password, user.PasswordStr))
                        {
                            return true;
                        }
                    }
                }
                // trường hợp cho student
                if (role == Role.StudentRole)
                {
                    using (var dataContext = getDataContext())
                    {
                        var user = dataContext.Students.FirstOrDefault(x => x.StudentId == username);
                        if (BCryptHelper.CheckPassword(password, user.PasswordStr))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception)
            {

            }
            return false;
        }

        /// <summary>
        /// Hàm kiểm tra lần đăng nhập đầu tiên của thủ thư đầu tiên
        /// </summary>
        /// <returns>trả về giá trị boolean true hoặc false</returns>
        public bool IsFirstLoginManager()
        {
            using (var dataContext = getDataContext())
            {
                return dataContext.LibManagers.Count() == 0;
            }
        }



        #endregion

        #region service for manager
        /// <summary>
        /// Thêm sách vào thư viện, Cần tạo đủ các text box truyền thằng vào hàm
        /// Hàm đã có các câu lệnh kiểm trả chuyển số liệu
        /// </summary>
        /// <remarks>Thông số sau đây bắt buộc người dùng nhập, nếu không ràng buộc được phải để trong try catch</remarks>
        /// <param name="title">tên sách</param>
        /// <param name="quantity">số lượng sách</param>
        /// <remarks>Thông số sau đây không bắt buộc người dùng nhập</remarks>
        /// <param name="isbn">ISBN</param>
        /// <param name="publishedYear">Năm xuấn bản</param>
        /// <param name="description">Mô tả</param>
        /// <param name="authorName">Tên tác giả</param>
        /// <param name="publisherName">Tên nhà xuất bản</param>
        /// <param name="category">Thể Loại Sách</param>
        public void AddBookToLibrary(string title,
            string quantity,
            string isbn,
            string publishedYear,
            string description,
            string authorName,
            string publisherName,
            string category)
        {
            int quantityInt;
            int publishedYearInt;
            //kiểm tra và chuyển đổi format
            if (String.IsNullOrEmpty(title))
            {
                title = null;
            }
            else
            {
                using (var dataContext = getDataContext())
                {
                    Book book = dataContext.Books.SqlQuery("select * from Book").FirstOrDefault(x => x.Title.ToLower() == title.ToLower());
                    if (book != null)
                    {
                        if (book.Author.AuthorName == authorName)//trung tac gia
                            throw new InvalidOperationException();
                    }

                }
            }

            if (String.IsNullOrEmpty(quantity))
            {
                throw new FormatException(nameof(quantity));
            }
            else
            {
                quantityInt = int.Parse(quantity);
                if (quantityInt <= 0)
                    throw new FormatException(nameof(quantity));
            }

            if (String.IsNullOrEmpty(isbn))
            {
                isbn = null;
            }

            if (String.IsNullOrEmpty(publishedYear))
            {
                publishedYearInt = -1;
            }
            else
            {
                publishedYearInt = int.Parse(publishedYear);
                if (publishedYearInt <= 0)
                    throw new FormatException(nameof(publishedYear));
            }

            if (String.IsNullOrEmpty(description))
            {
                description = null;
            }

            if (String.IsNullOrEmpty(authorName))
            {
                authorName = null;
            }

            if (String.IsNullOrEmpty(publisherName))
            {
                publisherName = null;
            }

            if (String.IsNullOrEmpty(category))
            {
                category = null;
            }


            BookTableManipulation.AddBook(title, quantityInt, isbn, publishedYearInt, description, authorName, publisherName, category);

        }

        public void DeleteBook(int Id)
        {
            BookTableManipulation.Remove(Id);
        }

        public void UpdateBook(int Id,
            string title,
            string quantity,
            string isbn,
            string publishedYear,
            string description,
            string authorName,
            string publisherName,
            string category)
        {
            int quantityInt;
            int? publishedYearInt;
            int? authorId;
            int? publisherId;
            int? categoryId;
            if (String.IsNullOrEmpty(title))
            {
                throw new FormatException(nameof(title));
            }
            else
            {
                using (var dataContext = getDataContext())
                {
                    Book book = dataContext.Books.FirstOrDefault(x => x.Id == Id);
                    if (book == null)
                        throw new InvalidOperationException("Not found record");
                }
            }
            if (String.IsNullOrEmpty(quantity))
            {
                throw new FormatException(nameof(quantity));
            }
            else
            {
                quantityInt = int.Parse(quantity);
                if (quantityInt <= 0)
                    throw new FormatException(nameof(quantity));
            }

            if (String.IsNullOrEmpty(isbn))
            {
                isbn = null;
            }

            if (String.IsNullOrEmpty(publishedYear))
            {
                publishedYearInt = null;
            }
            else
            {
                publishedYearInt = int.Parse(publishedYear);
                if (publishedYearInt <= 0)
                    throw new FormatException(nameof(publishedYear));
            }

            if (String.IsNullOrEmpty(description))
            {
                description = null;
            }

            if (String.IsNullOrEmpty(authorName))
            {
                authorId = null;
            }
            else
            {
                Author author = getDataContext().Authors.FirstOrDefault(x => x.AuthorName.ToLower() == authorName.ToLower());
                if (author == null)
                {
                    Author newAuthor = new Author() { AuthorName = authorName };
                    AuthorTableManipulation.Add(newAuthor);
                    authorId = AuthorTableManipulation.GetId(authorName);
                }
                else
                    authorId = author.Id;
            }

            if (String.IsNullOrEmpty(publisherName))
            {
                publisherId = null;
            }
            else
            {
                Publisher publisher = getDataContext().Publishers.FirstOrDefault(x => x.PublisherName.ToLower() == publisherName.ToLower());
                if (publisher == null)
                {
                    Publisher newPublisher = new Publisher() { PublisherName = publisherName };
                    PublisherTableManipulation.Add(newPublisher);
                    publisherId = PublisherTableManipulation.GetId(publisherName);
                }
                else
                    publisherId = publisher.Id;
            }

            if (String.IsNullOrEmpty(category))
            {
                categoryId = null;
            }
            else
            {
                Category categoryEnity = getDataContext().Categories.FirstOrDefault(x => x.CategoryName.ToLower() == category.ToLower());
                if (categoryEnity == null)
                {
                    Category newCategory = new Category() { CategoryName = category };
                    CategoryTableManipulation.Add(newCategory);
                    categoryId = CategoryTableManipulation.GetId(category);
                }
                else
                    categoryId = categoryEnity.Id;
            }
            Book toEdit = new Book()
            {
                Title = title,
                ISBN = isbn,
                PublishedYear = publishedYearInt,
                Quantity = quantityInt,
                BookDecription = description,
                AuthorId = authorId,
                PublisherId = publisherId,
                CategoryId = categoryId

            };
            BookTableManipulation.UpdateBookRecord(Id, toEdit);
        }

        public void AddBookLending(BookLending bookLending)
        {
            if(bookLending == null)
                throw new ArgumentNullException(nameof(bookLending));
            BookLendingTableManipulation.Add(bookLending);
        }

        public void ReturnBookLending(int idStudent, int idLibManager)
        {
            BookLendingTableManipulation.ReturnBook(idStudent, idLibManager);
        }

        public void RenewBookLending(int idStudent, int idLibManager)
        {
            BookLendingTableManipulation.RenewBook(idStudent, idLibManager);
        }
        #endregion
    }
}
