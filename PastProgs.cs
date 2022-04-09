global using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleApp2
{
    internal class PastProgs
    {
        void Past()
        {
            
            Action<int> printmultiply = Multiply(3);
            printmultiply(2);

            Action<int> Multiply(int x)
            {
                void SumInnerThingie(int y)
                {
                    Console.WriteLine(y*x);
                }
                return SumInnerThingie;
            }
            
            Converter<VEngines, Engines> converter = convert;
            convert(new VEngines(2, WriteLine));
        }

        static REngines convert(Engines engine) => new(engine.hp, WriteLine);

        delegate T Converter<in M, out T>(M parama);
    }
}
/*
Matrix a = new(12,"red",7.0,Write);

Phones<double> b = a switch {
    {Color: "red"} when a.Diametr >= 3.0 => new Phones<double>(6.5, WriteLine),
    {Color: "green"} when a.Diametr >= 3.0 => new Phones<double>(1.5, WriteLine),
    { } => new Phones<double>(228.0, WriteLine),
    null => new Phones<double>(0.0, WriteLine)
};

b.Specs();


(int, string, int) sumTuple = (2, "OnCoal", 5);
var (cringeSize, cringeTypo) = (3, "OnGrill");
WriteLine($"{sumTuple}");
string e = sumTuple.GetType().ToString();
WriteLine($"{e}");
*/
/*
Thread sumThread1 = new Thread(PrintxTimes);
Thread sumThread2 = new Thread(PrintxTimes);
Thread sumThread3 = new Thread(PrintxTimes);

sumThread1.Start(new PrintxTimesParam("You smell like the tastiest cheesecake i have ever eaten!!!~", 4));
Thread.Sleep(30);
sumThread3.Start(new PrintxTimesParam("Your voice is more beatiful than the birds singing!!!!! ^^", 3));

WriteLine("Main thread falling to sleep... zzz");
Thread.Sleep(500);
WriteLine("Main thread is waking up!");

sumThread2.Start("e");
WriteLine("The main thread action");

void PrintxTimes(object? param)
{
    if (param is PrintxTimesParam realParam)
    {
        for (int i = 0; i < realParam.times; i++)
        {
            WriteLine(((PrintxTimesParam)realParam).daMes);
            Thread.Sleep(100);
        }
    }
    else
        WriteLine("invalid parameter");
}
class PrintxTimesParam
{
    public string daMes;
    public int times;
    public PrintxTimesParam(string daMes, int times)
    {
        this.times = times;
        this.daMes = daMes;
    }
}
*/
/*
Engines asd = new(2, WriteLine);
if (asd is IMovable asdw) asdw.SpeedUp(1);


Engines asda = new VEngines(2, WriteLine);
VEngines asdf = (VEngines)asda++;
WriteLine($"{asdf.GetType()} and {asdf.hp}\n{asda.GetType()} and {asda.hp}");
*/
