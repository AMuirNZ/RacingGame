using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    public class Thing
    {
        public string thingName { get; set; }
        public string myPictureBox { get; set; }
        public int racetrackLength { get; set; }
        public int thingID { get; set; }
    }

    class Larry : Thing
    {

        //Stats on the four ghosts. 
        // Ghosts were Originally named after the three stooges. Hence the names.  
        public Larry ()
        {
            thingName = "Inky";
            thingID = 1;
        }



    }

    class Curly : Thing
    {
        public Curly()
        {
            thingName = "Pinky";
            thingID = 2;

        }
    }

    class Moe : Thing
    {
        public Moe()
        {
            thingName = "Blinky";
            thingID = 3;
        }
    }

    class Shemp : Thing
    {
        public Shemp()
        {
            thingName = "Clyde";
            thingID = 4;
        }
    }
}



    
  
