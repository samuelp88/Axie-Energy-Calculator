using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overlay
{
    static class EnergyCounter
    {
        public static int energy = 3;
        public static int round = 1;
        public static void addEnergy() {
            energy++;
            if (energy > 10) energy = 10;
        }

        public static void removeEnergy()
        {
            energy--;
            if (energy < 0) energy = 0;
        }

        public static void nextRound ()
        {
            energy += 2;
            round++;
            if (energy > 10) energy = 10;
        }

        public static void reset()
        {
            round = 1;
            energy = 3;
        }
    }
}
