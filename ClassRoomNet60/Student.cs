using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        public string Name { get; private set; }
        public int BirthMonth { get; private set; }
        public int BirthDay { get; private set;  }

        public Student(string name, int birthMonth, int birthDay)
        {
            Name = name;
            BirthMonth = birthMonth;
            BirthDay = birthDay;

        }

        //public ToString løsning til Task 4.
        public override string ToString()
        {
            return ($"Name:{Name}, birth month, {BirthMonth}, birth day  {BirthDay}");
            
        }



    }
}
