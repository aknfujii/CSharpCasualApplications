using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNote
{
    public partial class FormFusen : Form
    {
        private int mouseX;
        private int mouseY;

        public FormFusen()
        {
            InitializeComponent();
        }

        //type from keyboard on textbox
        private void textFusenMemo_KeyDown(object sender, KeyEventArgs e)
        {
            //if clicked escape key or not
            if(e.KeyCode==Keys.Escape)
            {
                this.Close();
            }

        }
        
        //mouseclick on textbox
        private void textFusenMemo_MouseDown(object sender, MouseEventArgs e)
        {
            //if left button clicked
            if (e.Button==MouseButtons.Left)
            {
                this.mouseX = e.X;
                this.mouseY = e.Y;

            }
        }

        //move mouse on textbox
        private void textFusenMemo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;

            }
        }

        private void textFusenMemo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //show clor setting dialog
            colorDialogFusen.ShowDialog();
            //set color on textbox background
            textFusenMemo.BackColor = colorDialogFusen.Color;
        }
    }
}
