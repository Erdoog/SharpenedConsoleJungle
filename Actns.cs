using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleApp2
{
    public class EekumBokum
    {
        public EekumBokum(GetClrById colorIt)
        {
            this.colorIt = colorIt;
        }
        public void Printsmthn(string mes, int clr)
        {
            ConsoleColor prevclr = Console.ForegroundColor;
            ForegroundColor = colorIt(clr);
            WriteLine(mes);
            ForegroundColor = prevclr;
        }
        public GetClrById colorIt;
    }
    public delegate ConsoleColor GetClrById(int content);

    public delegate int Maths(int a, int x);
    public enum MathExps
    {
        Add,
        Subtract,
        Devide,
        Multiply
    }
    public static class MathExpsEnum
    {
        public static Maths? MathType(MathExps exp)
        {
            return exp switch
            {
                MathExps.Add => (x, y) => x + y,
                MathExps.Subtract => (x, y) => x - y,
                MathExps.Devide => (x, y) => x / y,
                MathExps.Multiply => (x, y) => x * y,
                _ => null
            };
        }
    }
}
