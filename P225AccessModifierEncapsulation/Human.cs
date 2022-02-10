using System;
using System.Collections.Generic;
using System.Text;
using P225DemoLibrary;

namespace P225AccessModifierEncapsulation
{
    class Human : Teacher
    {
        private string _name;

        //protected string SurName;

        //private readonly int _age;
        //public readonly int _age;
        private int _age;

        public Human()
        {
        }

        public int Age
        {
            get 
            {
                return _age;
            }
            set 
            {
                if (value > 0 && value < 130)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Daxil Etdiyniz Yas Sehfdir");
                    return;
                }
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 5)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Duzgun Daxil Et");
                    return;
                }
            }
        }

        //public void SetName(string name)
        //{
        //    if (name.Length > 5)
        //    {
        //        _name = name;
        //    }
        //}

        //public string GetName()
        //{
        //    return _name;
        //}

        //public void ShowInfo()
        //{

        //    Console.WriteLine(_name+" "+SurName);
        //}
    }
}
