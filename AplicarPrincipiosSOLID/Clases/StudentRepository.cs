using AplicarPrincipiosSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicarPrincipiosSOLID.Clases
{
    public class StudentRepository : IStudentRepository
    {
        public void Save(Student student)
        {
            Console.WriteLine("Saving student to DB...");
            // 
        }

        public void Delete(Student student)
        {
            Console.WriteLine("Deleting student from DB...");
            // 
        }
    }
}
