using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homer

{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PIN { get; set; }

        public string GetNameSurname()
        {
            return $" Name: {Name} Surname: {Surname} PIN: {PIN} ";

        }
    }
}




