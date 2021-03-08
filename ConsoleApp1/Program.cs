using System;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student(123, "Razvan", 21, 10.3f, Finantare.Buget);
            Console.WriteLine(s1);
            s1.Grad = (Finantare)2;
            Console.WriteLine(s1);





        }
    }
}
