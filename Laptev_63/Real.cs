using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptev_63
{
    internal class Real : Number
    {
        public double R1 { get; set; }
        public double R2 { get; set; }
        public string Operation2 { get; set; }
        public Real(double r1, double r2)
        {
            R1 = r1;
            R2 = r2;
        }

        public override double Div()
        {
            return R1 / R2;
        }

        public override double Mult()
        {
            return R1 * R2;
        }
        public override double Sub()
        {
            return R1 - R2;
        }
        public override double Sum()
        {
            return R1 + R2;
        }
        public override string Print()
        {
            return $"Summa = {Sum()} " + $"Raznost = {Sub()}\n" + $"Proizvedenie = {Mult()} " + $"Delenie = {Div()}";
        }
    }

}
