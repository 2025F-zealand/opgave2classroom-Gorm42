using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        public string ClassName { get; set; }
        public List<Student>? StudentList { get; set; }
        public DateTime SemesterStart { get; set; }

        public ClassRoom(string className)
        {
            className = ClassName;
        }

        //public void PrintStudentList(ClassRoom room)
        //{
        //    foreach (Student student in List<Student>)
        //    {
        //        Console.WriteLine(student.Name);
        //        Console.WriteLine(student.BirthDay.ToString());
        //        Console.WriteLine(student.BirthMonth.ToString());
        //    }
        //}
    }
}
