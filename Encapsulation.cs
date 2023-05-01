using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A_Assignment
{
    public class Encapsulation
    {
        private string StudentName;
        private int StudentRollNo;

        public string Name
        {
            get
            {
                return StudentName;
            }

            set
            {
                StudentName = value;
            }
        }

        public int RollNo
        {
            get
            {
                return StudentRollNo;
            }
            set
            {
                StudentRollNo = value;
            }
        }

    }

}
    

