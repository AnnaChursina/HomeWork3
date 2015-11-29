using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SilentBob: Gambler

    {
        public SilentBob() : base("SilentBob")
        {
        }
        override public  void FetchNewNumber(object sender, ForEvent args)
        {
            if (!args.Number.isEvent()) Score++; // protected set у Score
        }
    }
}
