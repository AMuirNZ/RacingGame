using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public abstract class Punter
    {
        public string name { get; set; }
        public int cash { get; set; }
        public int thingNumber { get; set; }
        public int betAmount { get; set; }
        public string thingName { get; set; }
        public int id { get; set; }
        public RadioButton myRadioButton { get; set; }




    }

}

