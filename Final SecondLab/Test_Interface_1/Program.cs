using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            UpdateBasicCalculator c = new UpdateBasicCalculator("plexton", "100");
            c.ShowInfo();
            c.division(20, 30);
            c.multiplication(120, 30);
            c.sub(28, 33);
            c.sum(20, 30);

            UpdateScientificCalculator s = new UpdateScientificCalculator("gtx", " fx-500"); ;
            s.ShowInfo();
            s.factorial(520);
            s.XtoY(20, 33);
            s.sum(20,50);
            s.sub(65,72);
            s.multiplication(50, 60);
            s.division(130,140);

        }
    }
}

