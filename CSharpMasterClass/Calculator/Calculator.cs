using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        public string Addition(double input1, double input2) => 
            $"The Addition of Numbers {input1} & {input2} gives => {input1 + input2}";

        public string Subtraction(double input1, double input2) =>
            $"The Subtraction of Numbers {input1} & {input2} gives => {input1 - input2}";

        public string Multiplication(double input1, double input2) =>
            $"The Multiplication of Numbers {input1} & {input2} gives => {input1 * input2}";

        public string Division(double input1, double input2) =>
            $"The Division of Numbers {input1} & {input2} gives => {input1 / input2}";

    }
}
