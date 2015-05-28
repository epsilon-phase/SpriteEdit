using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices.WindowsRuntime;

namespace SpriteEdit2
{
    [Serializable]
    class Frame
    {
        private Color[,] contents;
        
        public Color[,] Contents { get { return contents; } }

        public int Width
        {
            get { return Contents.GetLength(0); }
        }

        public int Height
        {
            get { return contents.GetLength(1); }
        }
        /// <summary>
        /// Returns a single frame.
        /// </summary>
        /// <param name="w">The width of the frame</param>
        /// <param name="h">The height of the frame, in pixels</param>
        /// <param name="defval">The default color of the frame.</param>
        public Frame(int w, int h,Color defval)
        {
            contents=new Color[w,h];
            foreach (var i in Utility.Range(0, w, 1))
                foreach (var j in Utility.Range(0, h, 1))
                    contents[i, j] = defval;
                
        }

        public Frame(Frame e)
        {
            contents=new Color[e.Width,e.Height];
            foreach (var i in Utility.Range(0, contents.GetLength(0), 1))
                foreach (var j in Utility.Range(0, contents.GetLength(1), 1))
                    contents[i, j] = e.contents[i, j];
        }
        

    }
}
