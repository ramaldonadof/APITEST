using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APITEST.Database.Models;

namespace APITEST.Database
{
    public class StudentTableDB : IStudentTableDB
    {
        public List<Student> GetAll()
        {
            return new List<Student>();
        }
    }
}
