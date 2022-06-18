using System;
using System.Collections.Generic;
using System.Linq;

namespace Prac2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student()
            {
                Id = 1,
                Name = "Tanvir",
                Cgpa = 3.8,
                Dob = new DateTime(1998, 2, 1),

            };

            Student st2 = new Student()
            {
                Id = 2,
                Name = "Upol",
                Cgpa = 3.9,
                Dob = new DateTime(1999, 2, 1),

            };

            Student st3 = new Student()
            {
                Id = 3,
                Name = "Tahshin",
                Cgpa = 2.9,
                Dob = new DateTime(2009, 2, 1),

            };

            Student st4 = new Student()
            {
                Id = 4,
                Name = "Akash",
                Cgpa = 3.1,
                Dob = new DateTime(2006, 2, 1),



            };
            Student st5 = new Student()
            {
                Id = 4,
                Name = "Bob",
                Cgpa = 2.5,
                Dob = new DateTime(2010, 2, 1),

            };



            var Students = new List<Student>();
            Students.Add(st1);
            Students.Add(st2);
            Students.Add(st3);
            Students.Add(st4);
            Students.Add(st5);

            var res1 = (from Student in Students where Student.Cgpa>3.0 select Student).ToList();

            Console.WriteLine("Student with CGPA above 3.0 \n");
            foreach (var st in res1)
            {
                Console.WriteLine($"\nID: {st.Id} \nName: {st.Name} \nCGPA: {st.Cgpa} \nDob: {st.Dob.Year}");
            }


            var res2 = (from Student in Students where Student.Cgpa > 2.8 && Student.Id >3 select Student).ToList();

            Console.WriteLine("\nStudent with CGPA above 2.8 and ID over 3 \n");
            foreach (var st in res2)
            {
                Console.WriteLine($"\nID: {st.Id} \nName: {st.Name} \nCGPA: {st.Cgpa} \nDob: {st.Dob.Year}");
            }

            var res3 = (from Student in Students where (DateTime.Today.Year - Student.Dob.Year > 18) select Student).ToList();

            Console.WriteLine("\nStudent with age above 18 \n");
            foreach (var st in res3)
            {
                Console.WriteLine($"\nID: {st.Id} \nName: {st.Name} \nCGPA: {st.Cgpa} \nDob: {st.Dob.Year}");
            }

            var res4 = (from Student in Students  select new { ID = Student.Id, CGPA = Student.Cgpa }).ToList();


            Console.WriteLine("\nOnly ID and CGPA \n");
            foreach (var st in res4)
            {
                Console.WriteLine($"\nID: {st.ID}  \nCGPA: {st.CGPA} ");
            }


            var res5 = (from Student in Students where (DateTime.Today.Year - Student.Dob.Year > 16) select new { ID = Student.Id, Dob = Student.Dob }).ToList();


            Console.WriteLine("\nOnly ID and Dob where Dob is above 16 \n");
            foreach (var st in res5)
            {
                Console.WriteLine($"\nID: {st.ID}  \nCGPA: {st.Dob.Year} ");
            }

        }
    }
}
