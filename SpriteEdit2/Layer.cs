using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Microsoft.Win32;

namespace SpriteEdit2
{
    
    class Layer
    {
        /// <summary>
        /// Specifies the relative draw order of the layers.
        /// </summary>
        public int Order { get; set; }
        public int Width { get { return frames[0].Width; } }
        public int Height { get { return frames[0].Height; } }
        private List<Frame> frames;
        public int CurrentFrame { get; set; }
        public int FrameCount { get { return frames.Count; }}
        public Color DefaultColor { get; set; }

        /// <summary>
        /// Access a specific pixel at any point in the layer.
        /// </summary>
        /// <param name="x">The x coordinate of the desired pixel</param>
        /// <param name="y">The y coordinate of the desired pixel</param>
        /// <param name="f">the Frame of the desired pixel, or <seealso cref="CurrentFrame" >the CurrentFrame</seealso></param>
        /// <returns></returns>
        public Color this[int x, int y, int? f=null]
        {
            get
            {
                return frames[f??CurrentFrame].Contents[x, y];
            }
            set
            {
                frames[f??CurrentFrame].Contents[x, y] = value;
                frames[f ?? CurrentFrame].SetManually = true;
            }
        }

        /// <summary>
        /// If true, tells the layer to return things only for what has been manually set in the past. Otherwise, assume that the blank frames are desired.
        /// </summary>
        public bool Commutative { get; set; }
        public void SetColor(int x, int y,Color c)
        {
            frames[CurrentFrame].Contents[x, y] = c;
        }

        public Color GetColor(int x, int y,int f=-1)
        {
            if(!Commutative)
                return frames[f>=0?f:CurrentFrame].Contents[x, y];
            for (int i = CurrentFrame; i >= 0; i--)
            {
                if (frames[i].SetManually)
                    return frames[i].Contents[x, y];
            }
            return frames[0].Contents[x, y];
        }
        
        public void AddFrame(bool copyLast=true)
        {
            frames.Add(copyLast ? new Frame(frames[FrameCount - 1]) : new Frame(Width, Height, Color.Transparent));
        }

        public void InsertFrame(int index, bool copybehind = true)
        {
            if (copybehind)
            {
                var q = new Frame(frames[index]);
                frames.Insert(index, q);
            }
            else
            {
                frames.Insert(index,new Frame(Width,Height,Color.Transparent));
            }
        }

        private Layer(int w, int h,Color c,int f)
        {
            Commutative = false;
            CurrentFrame = 0;
            DefaultColor = c;
            frames=new List<Frame>(f);
            for (var i = 0; i < f; i++)
            {
                frames.Add(new Frame(w,h,c));
            }
        }
        /// <summary>
        /// Make a new Layer.
        /// </summary>
        /// <param name="w">The width of the new Layer.</param>
        /// <param name="h">The height of the new Layer.</param>
        /// <param name="frames">The number of frames to initialize.</param>
        /// <param name="defaultColor">The color that the frame is set to by default. If none is specified, it is assumed that the default color should be White</param>
        /// <returns>A new Layer with specified width, height, default color, initialized with a specified number of frames.</returns>
        public static Layer MakeLayer(int w, int h,Color? defaultColor=null,int frames=1)
        {
            
            return new Layer(w,h,defaultColor??Color.White,frames);
        }



    }
}
