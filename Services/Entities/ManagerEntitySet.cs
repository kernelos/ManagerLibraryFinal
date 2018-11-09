using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DB;
using DevOne.Security.Cryptography.BCrypt;
namespace Services.Entities
{
    public class ManagerEntitySet:UserAwareEntitySet
    {
        public ManagerEntitySet(string username) : base(username)
        {
        }

       

        /// <summary>
        /// Phương thức lấy tất cả bảng dữ liệu của Thủ thư
        /// </summary>
        /// <returns>Đối tượng List của LibManager</returns>
        public IList<LibManager> GetAll()
        {
            return GetDataContext().LibManagers.ToList();
        }
        /// <summary>
        /// Phương thức dùng để thêm tài khoản mới của thủ thư vào trong database
        /// Đã bao gồm phương phức mã hóa cho mật khẩu.
        /// Một lưu ý rằng là Username đã được chuyển về chữ thường,
        /// vì vậy không phân biệt chữ thường và chữ hoa
        /// </summary>
        /// <param name="entity">Đối tượng thủ thư</param>
        /// <exception cref="ArgumentNullException">Khi truyền vào đối tượng Thủ thư có gái trị null</exception>
        /// <exception cref="ArgumentException">Khi username của thủ thư đã tồn tại</exception>
        /// <returns>trả về Id của thủ tư vừa được tạo trong database</returns>
        public int Add(LibManager entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            //kiểm tra format các trường dữ liệu
            if (!ValidFormatFeild(entity.Username, entity.PasswordStr, entity.PersonalId))
                throw new FormatException("format entity feild wrong");

            using (var dataContext = GetDataContext())
            {
                //băm password, chuyển username về chữ thường
                entity.PasswordStr = BCryptHelper.HashPassword(entity.PasswordStr, BCryptHelper.GenerateSalt(10));
                entity.Username = entity.Username.ToLower();
                
                //kiểm tra đã tồn tại trong database chưa
                if (dataContext.LibManagers.Any(x => x.Username == entity.Username))
                    throw new ArgumentException("Username Taken");
                
                //thêm vào bản LibManager
                var newRecord = dataContext.LibManagers.Add(entity);
                dataContext.SaveChanges();
                return newRecord.Id;
            }
        }
        /// <summary>
        /// Phương thức dùng để cập nhật thông tin người dùng bao gồm cả mật khẩu
        /// Dùng getAll để lấy id, hoặc bằng cách nào đó lấy id chính xác
        /// </summary>
        /// <exception cref="ArgumentNullException"
        /// <param name="entity">Đối tượng phải có id giống với id trong database</param>
        public void Update(LibManager entity)
        {
            
            if (entity == null)
                throw new ArgumentNullException("entity");

            if (!ValidFormatFeild(entity.Username, entity.PasswordStr, entity.PersonalId))
                throw new FormatException("format entity feild wrong");

            using (var dataContext = new LibraryManagementEntities())
            {
                DB.LibManager toEdit = dataContext.LibManagers.FirstOrDefault(x => x.Id == entity.Id);

                if (toEdit == null)
                    throw new Exception("Record Not Found");
                toEdit.Username = entity.Username.ToLower();
                toEdit.ManagerName = entity.ManagerName;
                toEdit.Birthday = entity.Birthday;
                toEdit.PersonalId = toEdit.PersonalId;
                if (toEdit.PasswordStr != entity.PasswordStr)
                    toEdit.PasswordStr = BCryptHelper.HashPassword(entity.PasswordStr, BCryptHelper.GenerateSalt(10));
                dataContext.SaveChanges();   
            }
        }
        /// <summary>
        /// Phương thức xóa tài khoản thủ thư
        /// </summary>
        /// <exception cref="Exception">Khi người thủ thư tự xóa chính mình hoặc username không có trong database</exception>
        /// <param name="username">tên đăng nhập của usename</param>
        public void Delete(string username)
        {
            using(var dataContent = GetDataContext())
            {
                LibManager manager = dataContent.LibManagers.FirstOrDefault(x => x.Username == username);
                if (manager.Id == GetCurrentManager(dataContent).Id)
                    throw new Exception("Remove yourseft");
                if (manager == null)
                    throw new Exception("Record Not Found");
                dataContent.LibManagers.Remove(manager);
                dataContent.SaveChanges();
            }
        }
    }
}
