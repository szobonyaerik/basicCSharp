using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodecoolTask1
{
    class MathClass
    {
        public double number1 { get; set; }
        public double number2 { get; set; }
        public string op { get; set; }

        public MathClass(double number1, double number2, string op )
        {
            this.number1 = number1;
            this.number2 = number2;
            this.op = op;

        }
    }
}
