using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using stone_paper_seissore_Game_Project;


namespace stone_paper_seissore_Game_Project
{
    public partial class FormMainGame : Form
    {
        public FormMainGame(short NumberofRound)
        {
            InitializeComponent();
            infoGame.RoundGame = NumberofRound;
            labRound.Text = RoundNum.ToString() + " / " + infoGame.RoundGame.ToString();
        }

        struct stInfoGame
        {
            public short RoundGame;
            public short playerwin;
            public short computerwin;
            public short Drow;
            public string WinName;
        }

        stInfoGame infoGame = new stInfoGame();
        public short RoundNum = 0;
        void imageChoice(string name,PictureBox Box)
        {
            switch (name)
            {
                case "Rock":
                    Box.Image = Properties.Resources.Rock;
                    break;
                case "Paper":
                    Box.Image = Properties.Resources.Paper;
                    break;
                case "Scissors":
                    Box.Image = Properties.Resources.Scissors;
                    break;
                
            }

        }
        void ChangeImage(string player1,string Computer)
        {
            imageChoice(player1, PbPlayer);
            imageChoice(Computer,PbComputer);
        }

        void changeColorWin(string win)
        {
            switch (win)
            {
                case "Drow":
                    panalRound.BackColor = Color.Yellow;
                    infoGame.Drow++;
                    break;
                case "player1":
                    panalRound.BackColor = Color.Lime;
                    infoGame.playerwin++;
                    labCountplayer.Text = infoGame.playerwin.ToString();
                    break;
                case "computer":
                    panalRound.BackColor = Color.Red;
                    infoGame.computerwin++;
                    labCountComputer.Text = infoGame.computerwin.ToString();
                    break;

            }

        }
        string WinRound(string player1,string player2)
        {
            string win = ClassGame.HowWin(player1, player2);
            changeColorWin(win);
            return win;
        }
        public void newRound(object sender)
        {

            RoundNum++;
            if (RoundNum > infoGame.RoundGame)
            {
                string WinName = ClassGame.WinName(infoGame.playerwin, infoGame.computerwin);

                Form frm = new FormResult(WinName, infoGame.playerwin, infoGame.computerwin, infoGame.Drow);
                Hide();
                frm.ShowDialog();
            }
            
            labRound.Text = RoundNum.ToString() + " / " + infoGame.RoundGame.ToString();
             Guna2Button btn = (Guna2Button)sender;
            ClassGame Round = new ClassGame();

            string Player1Choice = btn.Text;
            string ComputerChoice = Round.GetComputerChoice();

            ChangeImage(Player1Choice, ComputerChoice);

            labwinnameRound.Text = WinRound(Player1Choice, ComputerChoice);
            
        }

        private void guna2Button_Click(object sender, EventArgs e)
        {
            newRound(sender);
        }

        
    }
}
