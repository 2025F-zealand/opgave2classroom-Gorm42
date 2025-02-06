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
        public string Season()
        {
            //12, 1, 2 winter
            if (BirthMonth == 1 || BirthMonth == 2 || BirthMonth == 12)
            {
                return "Winter";
            }
            //3,4,5 spring
            else if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5)
            {
                return "Spring - at last!";
            }
            //6,7,8 summer
            else if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8)
            {
                return "Summer";
            }
            //9,10,11 autumn
            else
            {
                return "Autumn";
            }

        }




    }
}
