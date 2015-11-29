using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ForEvent:EventArgs
    {
        public ForEvent(int i)
        {
            Number = i;
        }
        public int Number { get; }
    }
}
