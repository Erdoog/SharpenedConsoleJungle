using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Phones<Typo>
    {
        public Action<string> notify;
        public static double Boktamash()
        {
            WriteLine("Общайся без матов дуралей");
            return 2.28;
        }
        public int ram;
        public Typo inches;
        protected internal readonly string firm;
        public Processor proc;
        public Phones(Typo inches, Action<string> notify, int ram = 6, string firm = "Samsung", Processor proc = (Processor)1)
        {
            this.notify = notify;
            this.inches = inches;
            this.ram = ram;
            this.firm = firm;
            this.proc = proc;
        }
        public void Specs() => notify($"\n- - - - - -\nFirm: {firm}\nScreen Size: {inches}\nRAM: {ram}\nProcessor: {proc}\n- - - - - -\n");
        public const string category = "Phonez";
    }
    public class Tablet<Typo> : Phones<Typo>
    {
        public bool kybrdConnectSprt;
        public Tablet(Typo inches, Action<string> notify, int ram = 6, string firm = "Samsung",
            Processor proc = (Processor)1, bool kybrdConnectSprt = false) : base(inches, notify, ram, firm, proc)
        {
            this.kybrdConnectSprt = kybrdConnectSprt;
        }
        public new void Specs()
        {
            base.Specs();
            Write($"Keyboard support: {kybrdConnectSprt}\n- - - - - -\n");
        }

    }

}
