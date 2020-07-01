using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class Car : Form
    {
        // Defining the objects
        Melcedes M1;
        BMW B1;
        Lexus L1;
        Toyota T1;
        public Car()
        {
            InitializeComponent();
        }
        // When the forms loads, I initialise the objects   
        public void Car_Load(object sender, EventArgs e)
        {
            M1 = new Melcedes(Melcedes.Text, MelcedesPicture);
            B1 = new BMW(BMW.Text, BMWPicture);
            L1 = new Lexus(Lexus.Text, LexusPicture);
            T1 = new Toyota(Toyota.Text, ToyotaPicture);
        }

        public void Start_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            if (M1.Picture.Location.Y < 600 &&
                B1.Picture.Location.Y < 600 &&
                L1.Picture.Location.Y < 600 &&
                T1.Picture.Location.Y < 600)
            {

                M1.Move2(rand.Next(0, 50));
                B1.Move2(rand.Next(0, 50));
                L1.Move2(rand.Next(0, 50));
                T1.Move2(rand.Next(0, 50));
            }
            else
            {
                string winner = "";
                for (int i = 0; i < 4; i++)
                {
                    if (M1.Picture.Location.Y >= 600)
                    {
                        winner = M1.Model;
                    }
                    else if (B1.Picture.Location.Y >= 600)
                    {
                        winner = B1.Model;
                    }
                    else if (L1.Picture.Location.Y >= 600)
                    {
                        winner = L1.Model;
                    }
                    else if (T1.Picture.Location.Y >= 600)
                    {
                        winner = T1.Model;
                    }
                    else
                    {
                        winner = "Something went wrong!";
                    }


                }
                MessageBox.Show("The car race is finished and winner is " + winner);
            }
        }
    }


}

