using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
namespace Services
{
    public class DBTable
    {
        public DBTable()
        {
            CreateDatabaseIfNotExists();
        }

        protected void CreateDatabaseIfNotExists()
        {
            using(var dataContext = new LibraryManagementEntities())
            {
                dataContext.Database.CreateIfNotExists();
            }
        }

        protected LibraryManagementEntities GetDataContext()
        {
            return new LibraryManagementEntities();
        }
    }
}
