using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APITEST.Database.Models;

namespace APITEST.Database
{
    public interface IStudentTableDB
    {
        public List<Student> GetAll();
    }
}
