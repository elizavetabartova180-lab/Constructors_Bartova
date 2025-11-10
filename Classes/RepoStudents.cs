using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Bartova.Classes
{
    public class RepoStudents
    {
        public static List<Student> AllStudents()
        {
            List<Student> allStudent = new List<Student>();
            allStudent.Add(new Student("Бартова", "Елизавета", "Юрьевна", false, 3));
            allStudent.Add(new Student("Шляпникова", "Юлия", "Сергеевна"));
            allStudent.Add(new Student("Братчиков", "Максим", "Афанасьевич", false, 2));
            allStudent.Add(new Student("Бтова", "Елизавета", "Юрьевна", false, 3));
            allStudent.Add(new Student("Тартова", "Елизавета", "Александровна", true));
            allStudent.Add(new Student("Шартова", "Алина", "Афанасьевна", false, 3));
            allStudent.Add(new Student("Мыльников", "Пётр", "Николаевич", false, 3));
            allStudent.Add(new Student("Сартова", "Мария", "Сергеевна", false, 1));
            allStudent.Add(new Student("Батова", "Елизавета", "Юрьевна"));
            allStudent.Add(new Student("Бартова", "Елена", "Сергеевна", false, 3));
            allStudent.Add(new Student("Бартова", "Елизавета", "Александровна", true, 3));
            allStudent.Add(new Student("Бартова", "Екатерина", "Сергеевна", true, 3));
            allStudent.Add(new Student("Бартова", "Елизавета", "Афанасьевна", false, 3));
            allStudent.Add(new Student("Бартова", "Изольда", "Сергеевна", true, 3));
            allStudent.Add(new Student("Бартова", "Елизавета", "Юрьевна", false, 3));
            allStudent.Add(new Student("Бартова", "Мария", "Сергеевна", true, 3));
            return allStudent;
        }
    }
}
