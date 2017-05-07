using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLab9
{
     public partial class Form1 : Form
     {
          int x = 100, y = 100;

          public Form1()
          {
               InitializeComponent();
          }


          private void Form1_Paint(object sender, PaintEventArgs e)
          {
               e.Graphics.FillRectangle((Brushes.Blue), x, y, 100, 100);
               //create object

          }


          private void Form1_KeyDown(object sender, KeyEventArgs e)
          {
               if (e.KeyData == Keys.Right)
               {
                    x += 5;
                    if (x >= 823 - 100)
                    {
                         x = 823 - 100;
                    }
               }
               if (e.KeyData == Keys.Left)
               {
                    x -= 5;
                    if (x <= 0)
                    {
                         x = 0;
                    }
               }

               if (e.KeyData == Keys.Up)
               {
                    y -= 5;
                    if (y <= 0)
                    {
                         y = 0; 
                    }
               }
               if (e.KeyData == Keys.Down)
               {
                    y += 5;
                    if (y >= 491 -30 - 100)
                    {
                         y = 491 - 30 - 100   ;
                    }
               }
          }

          private void moveTimer_Tick(object sender, EventArgs e)
          {
               Invalidate();
          }

     }
}