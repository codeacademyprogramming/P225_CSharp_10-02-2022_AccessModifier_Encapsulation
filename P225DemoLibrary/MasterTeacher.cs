using System;
using System.Collections.Generic;
using System.Text;

namespace P225DemoLibrary
{
    class MasterTeacher
    {
        public MasterTeacher()
        {
            Teacher teacher = new Teacher();

            Console.WriteLine(teacher.SurName);
        }
    }
}
