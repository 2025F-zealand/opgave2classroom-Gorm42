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






