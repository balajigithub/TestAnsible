using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class Division
    {
        public static string ReturnStr(int i)
        {
            if (i % 3 == 0 && i % 5 == 0) return "Ansible Australia";
            else if (i % 3 == 0) return "Ansible";
            else if (i % 5 == 0) return "Australia";
            return "";
        }
    }
}
