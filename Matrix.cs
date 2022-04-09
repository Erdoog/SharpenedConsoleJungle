global using static System.Console;


namespace ClassLibrary1
{
    public class Stick
    {
        public int length;
        string colorsimb = "";
        public string? Color
        {
            get { return colorsimb switch
                {
                    "@" => "red",
                    "#" => "green",
                    "/" => "black",
                    "!" => "unspecified",
                    _ => "U did something impossible"
                }; 
            }
            set 
            {
                colorsimb = value switch
                {
                    "red" => "@",
                    "green" => "#",
                    "black" => "/",
                    _ => "!"
                };
            }
        }
        private ConsoleColor ConsColor
        {
            get
            {
                return colorsimb switch
                {
                    "@" => ConsoleColor.Red,
                    "#" => ConsoleColor.Green,
                    "/" => ConsoleColor.DarkYellow,
                    _ => ConsoleColor.White,
                };
            }
        }
        double diametr; // Dont mind why is it named like that, this is a ling story
        public double Diametr {
            get => diametr;
            
            set
            {
                if (value > length)
                    throw new Exception();
                diametr = value;
            } 
        }
        public readonly bool bolsheChemUDilmurata;
        public Stick(int length, string? Color, double diametr, Sender handler)
        {

            this.length = length;
            this.Color = Color;
            this.Diametr = diametr;
            if (length > 30 && diametr > 5)
                this.bolsheChemUDilmurata = true;
            this.handler = handler;
        }
        public void Model()
        {
            handler($"\n");
            var oldcolor = Console.ForegroundColor;
            Console.ForegroundColor = ConsColor;
            for (int i = 0; i < length; i++)
            {
                handler("    ");
                for (int j = 0; j < Diametr; j++)
                {
                    handler($"{colorsimb}");
                }
                handler($"\n");
            }
            handler($"\n");
            Console.ForegroundColor = oldcolor;
        }
        public Sender handler;

        public static void AOT(ref int a, int b)
        {
            a += b;
            Console.WriteLine(a.ToString());
        }
    }
    public delegate void Sender(string? mes);
    
    public enum Processor : byte
    {
        exynos,
        bionic,
        snapdragon,
        mediatech
    }
}