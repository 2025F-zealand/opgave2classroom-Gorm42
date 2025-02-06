// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

Console.WriteLine("Hello, World!");

//Opretter ClassRoom.
ClassRoom d317 = new ClassRoom("Datamatiker");

//opretter de fire studenter.
Student studentGorm = new Student("Gorm", 08, 20);
Student studentJonas = new Student("Jonas", 11, 17);
Student studentOliver = new Student("Oliver", 4, 12);
Student studentKevin = new Student("Kevin", 2, 16);

//Opretter listen som studenter skal ned i og som skal ned i ClassRoom.
List<Student> studentDataList = new List<Student>();

//Tilføjer vores Student instanser til studentDataList
studentDataList.Add(studentGorm);
studentDataList.Add(studentJonas);
studentDataList.Add(studentOliver);
studentDataList.Add(studentKevin);

foreach (Student student in studentDataList)
{
    Console.WriteLine(student);
  
}

string Season(Student student)
{
    //12, 1, 2 winter
    if (student.BirthMonth == 1 || student.BirthMonth == 2 || student.BirthMonth == 12)
    {
        return "Winter";
    }
    //3,4,5 spring
    else if (student.BirthMonth == 3 || student.BirthMonth == 4 || student.BirthMonth == 5)
    {
        return "Spring - at last!";
    }
    //6,7,8 summer
    else if (student.BirthMonth == 6 || student.BirthMonth == 7 || student.BirthMonth == 8)
    {
        return "Summer";
    }
    //9,10,11 autumn
    else
    {
        return "Autumn";
    }
    
}







