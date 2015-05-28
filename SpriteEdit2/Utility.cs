using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpriteEdit2
{
    class Utility
    {
        public static IEnumerable<int> Range(int min, int max, int step = 1)
        {
            for (var i = min; i < max; i += step)
                yield return i;
        } 
    }
}
