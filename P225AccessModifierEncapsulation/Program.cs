using Demo;
using System;
using P225DemoLibrary;


namespace P225AccessModifierEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Access Modifier

            //Human human1 = new Human();
            //string name = "ali";
            //if (name.Length > 5)
            //{
            //    human1.Name = name;
            //}
            //else
            //{
            //    Console.WriteLine(human1.Name);
            //}


            ////human.SetName("Ali");
            ////Console.WriteLine(human.GetName());
            ////human.Name = "Ali";
            ////Console.WriteLine(human.Name);


            ////human.ShowInfo();

            //Human human2 = new Human();
            //Student student = new Student();
            //student.Name = "ali";
            //human2.Age = 135;

            //int num = human2.Age;
            //Console.WriteLine(human2.Age);
            #endregion

            //Demo.Human human = new Demo.Human();

            //Car car = new Car();

            //Teacher teacher = new Teacher();
            //char symbol = 'A';
            ////Console.WriteLine(char.IsWhiteSpace(symbol));
            ////Console.WriteLine(char.IsUpper(symbol));
            ////Console.WriteLine(char.IsControl(symbol));
            //Console.WriteLine(char.ToLower(symbol));

            Human human = new Human();
        }
    }
}

namespace Test
{
    class Car
    {
        public Car()
        {
            P225AccessModifierEncapsulation.Human human = new P225AccessModifierEncapsulation.Human();
        }
    }
}

namespace Demo
{
    class Human
    {

    }

    class Car
    {

    }
}
