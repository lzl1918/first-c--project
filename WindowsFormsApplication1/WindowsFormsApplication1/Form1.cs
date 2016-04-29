using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            const int cst = 5;
            if (this.Top < 1)
            {
                //if (this.Left >= Screen.PrimaryScreen.WorkingArea.Width - this.Width)
                    //开始往上移
                    while (this.Top >= 0 - this.Height + cst)
                    {
                        this.Top--;
                    }

            }


        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            if (this.Top == 5 - this.Height)
            {
                while (this.Top < 0)
                {
                    this.Top++;
                }
            }
        }

    }
}
