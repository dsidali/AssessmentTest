using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndSQL
{
    internal class Student
    {
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public List<Course> Courses { get; set; }  
    }
}
