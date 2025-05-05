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
    public partial class FormResult : Form
    {
        public FormResult(string WinName,short playerwintime,short Computerwinttime
            ,short Drowtime)
        {
            InitializeComponent();

            labtimePlayer.Text = playerwintime.ToString();
            labtimeComputer.Text = Computerwinttime.ToString();
            labtimeDrow.Text = Drowtime.ToString();
            labWinName.Text = WinName;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            Hide();
            frm.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
