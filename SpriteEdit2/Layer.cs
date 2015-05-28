using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace SpriteEdit2
{
    class Layer
    {
        private List<Frame> frames;
        public int CurrentFrame { get; set; }
        public int FrameCount { get { return frames.Count; }}
        public void SetColor(int x, int y,Color c)
        {
            frames[CurrentFrame].Contents[x, y] = c;
        }
    }
}
