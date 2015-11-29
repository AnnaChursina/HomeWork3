using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Jay : Gambler
    {
        public Jay() : base("Jay")
        {

        }

        override public void FetchNewNumber(object sender, ForEvent args) 
        {
            if (args.Number.isEvent()) Score++; // protected set у Score
        }
    }
}
