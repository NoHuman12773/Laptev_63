using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptev_63
{
    internal class Integer : Number
    {
        public double I1 { get; set; }
        public double I2 { get; set; }
        public string Operation1 { get; set; }
        public Integer(double i1, double i2)
        {
            I1 = i1;
            I2 = i2;
        }

        public override double Div()
        {
            return I1 / I2;
        }

        public override double Mult()
        {
            return I1 * I2;
        }
        public override double Sub()
        {
            return I1 - I2;
        }
        public override double Sum()
        {
            return I1 + I2;
        }
        public override string Print()
        {
            return $"Summa = {Sum()} " + $"Raznost = {Sub()}\n" + $"Proizvedenie = {Mult()} " + $"Delenie = {Div()}";
        }
    }
   
}
