using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpriteEdit2
{
    [Serializable]
    public class Preset
    {
        public Preset()
        {
            Sizes=new List<Size>();
        }
        public List<Size> Sizes { get; set; }
    }
}
