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

        int winterCounter;
        int springCounter;
        int summerCounter;
        int autumnCounter;

        public void SeasonCounter(List<Student> StudentList)
        {            
            foreach (Student student in StudentList) 
            {
                if (student.BirthMonth == 12 || student.BirthMonth == 1 || student.BirthMonth == 2)
                {
                    winterCounter++;
                }
                else if (student.BirthMonth == 3 || student.BirthMonth == 4 || student.BirthMonth == 5)
                {
                    springCounter++;
                }
                else if (student.BirthMonth == 6 || student.BirthMonth == 7 || student.BirthMonth == 8)
                {
                    summerCounter++;
                }
                else
                {
                    autumnCounter++;
                }
            }
            Console.WriteLine($"Der er {winterCounter} født om vinteren, {springCounter} født om foråret, {summerCounter} født om sommeren, og {autumnCounter} født i efteråret.");
            
        }

    }
}
