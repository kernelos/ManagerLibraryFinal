using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using DevOne.Security.Cryptography.BCrypt;
namespace Services.Entities
{
    public class StudentEntitySet : UserAwareEntitySet
    {

        /// <summary>
        /// Phương thức khởi tạo, cũng là để xác thực người dùng hệ thống
        /// </summary>
        /// <param name="user">Mã số sinh viên nếu của đối tượng là sinh viên
        /// username nếu là thủ thư</param>
        public StudentEntitySet(string user) : base(user)
        {
        }
        /// <summary>
        /// Phương thức lấy dữ liệu của bản Student trong database
        /// </summary>
        /// <returns>List cho phép thực hiện các truy vấn nâng cao</returns>
        public List<Student> GetAll()
        {
            return GetDataContext().Students.ToList();
        }
        /// <summary>
        /// Phương thức Add dùng để thêm sinh viên mới vào database
        /// Hãy tạo một đối tượng Student truyền vào hàm để add dữ liệu 
        /// sinh viên đó vào database
        /// </summary>
        /// <param name="entity">sinh viên</param>
        /// <exception cref="ArgumentNullException">truyền vào giá trị null</exception>
        /// <exception cref="ArgumentException">Sinh viên đó đã có trong database
        /// phương thức sẽ không thêm, tiêu chí so sánh là StudentId</exception>
        /// <returns>Trả về id của sinh viên đó trong bảng student</returns>
        public int Add(Student entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            if (!ValidFormatFeild(entity.StudentId, entity.PasswordStr, entity.PersonalId))
                throw new FormatException("Format of feild in Entity invalid");
            using (var dataContext = GetDataContext())
            {
                if (dataContext.Students.Any(x => x.StudentId == entity.StudentId))
                    throw new ArgumentException("Student Id have taken");
                entity.PasswordStr = BCryptHelper.HashPassword(entity.PasswordStr, BCryptHelper.GenerateSalt(10));
                Student newRecord = dataContext.Students.Add(entity);
                dataContext.SaveChanges();
                return newRecord.Id;
            }
        }
        /// <summary>
        /// Dùng để update thông tin sinh viên bao gồm cả mật khẩu
        /// </summary>
        /// <param name="entity">sinh viên</param>
        /// <exception cref="ArgumentException">Nếu vô tình truyền vào giá trị 
        /// null hay vì một lý do nào đó mà tham số truyền vào có giá trị null</exception>
        /// <exception cref="ArgumentException">Sinh viên đó không tồn tại trong database
        /// Phương thức sẽ không thực hiện gì</exception>
        public void Update(Student entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            if (!ValidFormatFeild(entity.StudentId, entity.PasswordStr, entity.PersonalId))
                throw new FormatException("Format of feild in Entity invalid");
            using (var dataContext = GetDataContext())
            {
                Student toEdit = dataContext.Students.FirstOrDefault(x => x.Id == entity.Id);
                if (toEdit == null)
                    throw new ArgumentException("Record not found");
                toEdit.StudentId = entity.StudentId;
                toEdit.StudentName = entity.StudentName;
                toEdit.PersonalId = entity.PersonalId;
                toEdit.Birthday = entity.Birthday;
                if (!string.IsNullOrWhiteSpace(entity.PasswordStr)&&toEdit.PasswordStr != entity.PasswordStr)
                    toEdit.PasswordStr = BCryptHelper.HashPassword(entity.PasswordStr, BCryptHelper.GenerateSalt(10));
                dataContext.SaveChanges();
            }
        }
        /// <summary>
        /// Phương thức xóa bỏ dữ liệu của sinh viên ra khỏi database
        /// </summary>
        /// <exception cref="Exception">Dữ liệu của sinh viên không tồn tại trong database</exception>
        /// <param name="id"></param>
        public void Delete(int Id)
        {
            using (var dataContext = GetDataContext())
            {
                Student student = dataContext.Students.FirstOrDefault(x => x.Id == Id);
                if (student == null)
                    throw new Exception("Record not found");
                dataContext.Students.Remove(student);
                dataContext.SaveChanges();
            }

        }

    }
}
