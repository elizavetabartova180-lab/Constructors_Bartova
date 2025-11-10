using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Bartova.Classes
{
    public class Student
    {
        public string FirstName = "";
        public string LastName = "";
        public string SurName = "";
        public bool Scholarship = false;
        public int Course = 4;
        public Student(string FirstName, string LastName, string SurName) 
        { 
            this.FirstName = FirstName;
            this.LastName = LastName;  
            this.SurName = SurName;
        }
        public Student(string FirstName, string LastName, string SurName, bool Scholarship) 
            :this(FirstName, LastName, SurName)
        { 
            this.Scholarship=Scholarship;
        }
        public Student(string FirstName, string LastName, string SurName, bool Scholarship, int Course)
            : this(FirstName, LastName, SurName, Scholarship)
        {
            this.Course = Course;
        }
        public string GetFIO()
        {
            return $"{LastName}{FirstName}{SurName}";
        }
    }
}
