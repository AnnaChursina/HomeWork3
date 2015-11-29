using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class Numbertron
    {
        public event EventHandler<ForEvent> NewNumber;
        //New Number событие 

        public void Generate()
        {
            Random figure = new Random();
            var i = figure.Next(0, 500);
            NewNumber?.Invoke(this, new ForEvent(i));
        }
    }
}




