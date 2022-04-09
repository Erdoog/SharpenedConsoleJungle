using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IMovable
    {
        const int minSpeed = 0;
        void SpeedUp(int speed)
        {
            if (speed < minSpeed) Console.WriteLine("sped up");
        }
        void MakeSounds() => WriteLine("gwwwwwwww rutututututu");    
    }
    public interface IConsumer
    {
        const int minFuel = 0;
        public void ConsumeSomeFuel(int fuel);
        public void MakeSounds() => WriteLine("bwwrrrrrrr woooooooo");
    }
}
