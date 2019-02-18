/*
 * Name : Manthan Jansari 
 * Student Id : 000741486
 * Date: 07-01-2018
 * purpose : The purpose of this assignment is to draw graphics using bultin function of .Net and 
 *              more over this file shows the bucket is filling and we can control the flow of it
 *              using trackbar and time is used to controll the timing of filling bucket
 * Statement of Authorship : I have done this assignment by my own
 * 
 */


using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5A
{
    public partial class Form1 : Form
    {
        private Graphics g;                         //Encapsulates a GDI+ drawing surface
        private Pen p;                              //Pens are used to draw objects
        private Color c = Color.Black;              //Represents a color, initially set to black
        private Font f;                             //Defines a particular format for text, including font face, size, and style attributes
        private SolidBrush b;                       //Brushes are used to fill graphics shapes
        private int t = 1;
        public Form1()
        {
            InitializeComponent();
            
            this.Paint += new PaintEventHandler(form1_Paint);  //Registers the Paint event handler
        }

        private void form1_Paint(object sender, PaintEventArgs e)
        {

            g = e.Graphics;                          //Get the Graphics object from the PaintEventArgs
            p = new Pen(Color.Black);                          //Create a new Pen using the current colour
            f = new Font("Arial", 20);               //Create a new Font
            b = new SolidBrush(c);                   //Create a new brush using the current colour

            
            g = this.CreateGraphics();               //Create a graphics object

            g.DrawLine(p, 200, 200, 200, 300);  //Save the colour choice the user made
            g.DrawLine(p, 400, 300, 200, 300);  //Save the colour choice the user made
            g.DrawLine(p, 400, 300, 400, 200);  //Save the colour choice the user made

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void colourbtn_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = c;                //Display with the previous colour already chosen
            colorDialog1.ShowDialog();             //Display the actual dialog box
            c = colorDialog1.Color;
            

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 100;
            trackBar1.TickFrequency = 10;
            
            
            if (trackBar1.Value == 1)
            {
                
                timer1.Stop();
            }
            else
            {
                g.DrawLine(p, 230, 300, 230, 100);
                g.DrawLine(p, 231, 300, 231, 100);
                g.DrawLine(p, 232, 300, 232, 100);
                g.DrawLine(p, 233, 300, 233, 100);
                g.DrawLine(p, 234, 300, 234, 100);
                g.DrawLine(p, 235, 300, 235, 100);
                g.DrawLine(p, 236, 300, 236, 100);
                g.DrawLine(p, 239, 300, 239, 100);
                g.DrawLine(p, 238, 300, 238, 100);
                g.DrawLine(p, 237, 300, 237, 100);

                timer1.Start();
                timer1.Interval = 101 - trackBar1.Value;
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            p = new Pen(c);                          //Create a new Pen using the current colour

            if (t != 90)
            {
               
                g.DrawLine(p, 400, 300 - t, 200, 300 - t);  //Save the colour choice the user made
                t++;
            }

            else
            {
                timer1.Stop();
                Refresh();
                t = 0;
                trackBar1.Value = 1;
            }
        }
    }
}
