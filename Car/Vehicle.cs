using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public abstract class Vehicle
    {
        public abstract string Model { get; set; }
        public abstract PictureBox Picture { get; set; }
        public abstract void Move2(int distance);
    }
}
