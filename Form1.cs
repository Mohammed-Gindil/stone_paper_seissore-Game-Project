using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stone_paper_seissore_Game_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form frm = new FormMainGame(Convert.ToInt16(guna2NumericUpDown1.Value));
            Hide();
            frm.ShowDialog();
        }
    }
}
