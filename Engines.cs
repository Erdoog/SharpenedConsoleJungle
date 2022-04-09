global using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Engines : IMovable, ICloneable
    {
        public int hp;
        public int curFuel;
        Action<string> notify;
        public Engines(int hp, Action<string> notify)
        {
            this.hp = hp;
            this.notify = notify;
        }
        public void ConsumeSomeFuel(int fuel)
        {
            if (fuel > curFuel) notify?.Invoke("Ur cringe, theres no so much fuel");
        }
        public void MakeSounds()
        {
            WriteLine("AWOOOOOOOOOOOOO");
        }

        public virtual void GetPower()
        {
            WriteLine($"HPs: {hp}");
        }
        public object Clone()
        {
            return new Engines(hp, notify);
        }
        public static Engines operator ++(Engines engine)
        {
            return new Engines(engine.hp + 10, engine.notify);
        }
    }
    public class VEngines : Engines
    {
        public VEngines(int hp, Action<string> notify) : base(hp, notify)
        {

        }
    }
    public class REngines : Engines
    {
        public REngines(int hp, Action<string> notify) : base(hp, notify)
        {

        }
    }
}
