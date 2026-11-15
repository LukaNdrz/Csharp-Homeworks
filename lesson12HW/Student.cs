using System;
using System.Collections.Generic;
using System.Text;

namespace lesson12HW
{
  internal class Student
  {
    public string Name;
    public string Surname;
    public int Age;
    public int Grade;

    public Student(string name, string surname, int age, int grade)
    {
      Name = name;
      Surname = surname;
      Age = age;
      Grade = grade;
    }
  }
}
