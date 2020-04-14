using APITEST.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APITEST.Database;

namespace APITEST.BusinessLogic
{
    public class GroupLogic : IGroupLogic
    {
        private readonly IStudentTableDB _studentTableDB;

        public GroupLogic(IStudentTableDB studentTableDB)
        {
            _studentTableDB = studentTableDB;
        }

        public List<Group> GetGroupsCERTClass()
        {
            List<Database.Models.Student> allStudents = _studentTableDB.GetAll();
            // Process all stundents
            return new List<Group>();
        }
    }
}
