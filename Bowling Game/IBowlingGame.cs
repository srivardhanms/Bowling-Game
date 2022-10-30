using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Game
{
    internal interface IBowlingGame
    {
        void Roll(int NoOfPins);
        int Score();
    }
}
