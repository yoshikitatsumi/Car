﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public class Melcedes:Vehicle
    {
        public override string Model { get; set; }
        public override PictureBox Picture { get; set; }
        public Melcedes(string tempName, PictureBox tempPic)
        {
            Model = tempName;
            Picture = tempPic;
        }
        public override void Move2(int distance)
        {

            Picture.Location = new Point(Picture.Location.X, Picture.Location.Y + distance);
        }
    }
}
