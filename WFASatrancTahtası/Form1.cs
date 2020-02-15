using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFASatrancTahtası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            for(int x = 0; x < 8; x++)
            {
                for(int y = 0; y < 8; y++)
                {
                    Label lbl = new Label();
                    lbl.Height = lbl.Width = 50;
                    lbl.Margin = new Padding(0);
                    if (x % 2 == 0)
                    {
                        if (y % 2 == 0)
                        {
                            lbl.BackColor = Color.White;

                        }
                        else
                        {
                            lbl.BackColor = Color.Black;
                        }
                    }
                    else
                    {
                        
                        if (y % 2 == 0)
                        {
                            lbl.BackColor = Color.Black;
                        }
                        else
                        {
                            lbl.BackColor = Color.White;
                        }
                    }
                    
                    flpSatranc.Controls.Add(lbl);
                }
               
            }
        }
    }
}
