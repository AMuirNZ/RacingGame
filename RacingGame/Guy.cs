using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{

    //Simple stats on all three betters
    class Joe : Punter
    {
        public Joe()
        {
            name = "Joe";
            cash = 45;
        }

    }

    class Al : Punter
    {
        public Al()
        {
            name = "Al";
            cash = 35;

        }

       
    }

    class Bob : Punter
    {
        public Bob()
        {
            name = "Bob";
            cash = 40;
        }
    }
    
}
