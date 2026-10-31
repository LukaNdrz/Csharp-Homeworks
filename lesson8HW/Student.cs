using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace lesson8HW
{
  internal class Student
  {


    private string firstName;
    private string lastName;
    private int age;
    private string email;
    private string personalId;
    private string phone;
    private double gpa;
    private int course;
    private string faculty;
    private bool isActive;


    public string FirstName
    {
      get { return firstName; }
      set
      {
        if (value == null || !Regex.IsMatch(value, @"^\p{L}{2,30}$"))
        {
          throw new Exception("სახელი უნდა შედგებოდეს 2-30 ასოსგან");
        }
        firstName = value;
      }
    }


    public string LastName
    {
      get { return lastName; }
      set
      {
        if (value == null || !Regex.IsMatch(value, @"^\p{L}{2,30}$"))
        {
          throw new Exception("გვარი უნდა შედგებოდეს 2-30 ასოსგან");
        }
        lastName = value;
      }
    }


    public int Age
    {
      get { return age; }
      set
      {
        if (value < 16 || value > 100)
        {
          throw new Exception("ასაკი უნდა იყოს 16-დან 100-მდე");
        }
        age = value;
      }
    }

    public string Email
    {
      get { return email; }
      set
      {
        if (value == null || !Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        {
          throw new Exception("ელფოსტის ფორმატი არასწორია");
        }
        email = value;
      }
    }

    public string PersonalId
    {
      get { return personalId; }
      set
      {
        if (value == null || !Regex.IsMatch(value, @"^\d{11}$"))
        {
          throw new Exception("პირადი ნომერი უნდა შედგებოდეს ზუსტად 11 ციფრისგან");
        }
        personalId = value;
      }
    }

    public string Phone
    {
      get { return phone; }
      set
      {
        if (value == null || !Regex.IsMatch(value, @"^5\d{8}$"))
        {
          throw new Exception("ტელეფონი უნდა იყოს 9 ციფრი და იწყებოდეს 5-ით");
        }
        phone = value;
      }
    }

    public double Gpa
    {
      get { return gpa; }
      set
      {
        if (value < 0 || value > 100)
        {
          throw new Exception("GPA უნდა იყოს 0-დან 100-მდე");
        }
        gpa = value;
      }
    }

    public int Course
    {
      get { return course; }
      set
      {
        if (value < 1 || value > 6)
        {
          throw new Exception("კურსი უნდა იყოს 1-დან 6-მდე");
        }
        course = value;
      }
    }

    public string Faculty
    {
      get { return faculty; }
      set
      {
        if (string.IsNullOrWhiteSpace(value))
        {
          throw new Exception("ფაკულტეტი არ შეიძლება იყოს ცარიელი");
        }
        faculty = value;
      }
    }

    public bool IsActive
    {
      get { return isActive; }
      set { isActive = value; }
    }

    public void PrintInfo()
    {
      Console.WriteLine("სახელი: " + FirstName);
      Console.WriteLine("გვარი: " + LastName);
      Console.WriteLine("ასაკი: " + Age);
      Console.WriteLine("ელფოსტა: " + Email);
      Console.WriteLine("პირადი ნომერი: " + PersonalId);
      Console.WriteLine("ტელეფონი: " + Phone);
      Console.WriteLine("GPA: " + Gpa);
      Console.WriteLine("კურსი: " + Course);
      Console.WriteLine("ფაკულტეტი: " + Faculty);
      Console.WriteLine("აქტიურია: " + IsActive);
    }
  }
}
