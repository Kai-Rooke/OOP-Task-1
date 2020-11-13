using System;

namespace OOP_Task_1
{
    class Student
    {

        string studentId {get;set;}
        string firstName {get;set;}
        string lastName {get;set;}
        string otherNames {get;set;}
        int age {get;set;}
        string gender {get;set;}

        string dateOfBirth{get;set;}

        public Student (string studentId, string firstName, string lastName, string otherNames, int age, string gender, string dateOfBirth)
        {
            this.studentId = studentId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.otherNames = otherNames;
            this.age = age;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
        }

        public void DisplayReportCard()
        {
            Console.WriteLine("Report Card");
            Console.WriteLine();
            Console.WriteLine($"Name: {0}",firstName + "" + $"{1}",otherNames + "" + $"{2}", lastName);
            Console.WriteLine();
            Console.WriteLine($"Student ID: {0}",studentId);
        }
    }
}