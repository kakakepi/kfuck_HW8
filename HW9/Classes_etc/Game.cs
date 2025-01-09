using System;
using System.Collections.Generic;

namespace HW9
{
    public abstract class Game
    {
        protected Random random = new Random();

        public abstract void DistributePoints(List<Team> teams);
    }
}
