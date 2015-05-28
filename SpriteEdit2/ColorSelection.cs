using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpriteEdit2
{
    public partial class ColorSelection : UserControl
    {
        public Color Value { get; set; }
        public event EventHandler<EventArgs> ValueChanged; 
        public ColorSelection()
        {
            InitializeComponent();
            blueValue.Maximum = 255;
            redValue.Maximum = 255;
            greenValue.Maximum = 255;
            alphaValue.Maximum = 255;
            blueValue.ValueChanged += colorChangedHandler;
            redValue.ValueChanged += colorChangedHandler;
            greenValue.ValueChanged += colorChangedHandler;
            alphaValue.ValueChanged += colorChangedHandler;
        }

        void colorChangedHandler(object sender, EventArgs e)
        {
            Value = Color.FromArgb((int)alphaValue.Value, (int)redValue.Value, (int)greenValue.Value, (int)blueValue.Value);
            ColorDisplay.BackColor = Value;
            ColorDisplay.Refresh();
            
            if (ValueChanged != null)
            {
                ValueChanged.Invoke(this,new EventArgs());
            }
        }
    }
}
