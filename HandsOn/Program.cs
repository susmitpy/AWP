using System;
using System.Collections.Generic;

namespace HandsOn
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting Practicals");
            pracOne();
        }

        static void pracOne()
        {
            PracOne pracOne = new PracOne();
            pracOne.one();
            pracOne.two();
            pracOne.three();
        }
    }

    class PracOne
    {
        int a, b, c, d;
        string left, right, combined;
        List<Student> students = new List<Student>();
        int numStudents;

        public void one()
        {
            takeProductInput();
            showProduct();
        }

        void takeProductInput()
        {
            Console.WriteLine("You have to enter four integers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
        }

        void showProduct()
        {
            Console.WriteLine("Product = " + Convert.ToString(a * b * c * d));
        }

        public void two()
        {
            takeStrInput();
            showJoinedStr();
        }

        void takeStrInput()
        {
            Console.WriteLine("Enter left part of string : ");
            left = Console.ReadLine();
            Console.WriteLine("Enter Right part of string : ");
            right = Console.ReadLine();
            combined = left + " " + right;
        }

        void showJoinedStr()
        {
            Console.WriteLine("Joined: " + combined);
        }

        public void three()
        {
            takeStudentsData();
            showStudentsData();
        }

        void takeStudentsData()
        {
            Console.Write("No. of students: ");
            numStudents = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Students Data: ");
            for(int i = 0; i < numStudents; i++)
            {
                Student tempStudent = new Student();
                tempStudent.getInfo();
                students.Add(tempStudent);
            }
        }

        void showStudentsData()
        {
            Console.WriteLine("Students Data: ");
            for(int i = 0; i < numStudents; i++)
            {
                students[i].showInfo();
            }
        }
    }

    public class Student
    {
        int id;
        string studName, courseName, dob;

        public void showInfo()
        {
            Console.WriteLine("ID : " + Convert.ToString(id));
            Console.WriteLine("Student Name: " + studName);
            Console.WriteLine("Course Name: " + studName);
            Console.WriteLine("DOB : " + dob);
        }

        public void getInfo()
        {
            Console.Write("ID : ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Student Name : ");
            studName = Console.ReadLine();

            Console.Write("Course Name : ");
            courseName = Console.ReadLine();

            Console.Write("DOB (yyyy/mm/dd) : ");
            dob = Console.ReadLine();
        }
    }
}
