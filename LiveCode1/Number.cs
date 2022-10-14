using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCode1
{
    public class Number
    {
        public int Value { get; set; }

        public Number(int val)
        {
            Value = val;
        }

        public Number Add(Number n)
        {
            return new Number(this.Value + n.Value);
        }

        public static Number operator+(Number n1, Number n2)
        {
            return new Number(n1.Value + n2.Value);
        }

        public static Number operator +(Number n1, int n2)
        {
            return new Number(n1.Value + n2);
        }
    }
}
