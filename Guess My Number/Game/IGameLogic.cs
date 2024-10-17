using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_My_Number.Game
{
    public interface IGameLogic
    {
        public void checkGameState();
        public void updateGameState();
    }
}
