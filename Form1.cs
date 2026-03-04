using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public  class clsCount
        {
            public static int count = 0;
        }

        void EndGame(string TheWinner = "Draw")
        {
            pb1.Enabled = false;
            pb2.Enabled = false;   
            pb3.Enabled = false;
            pb4.Enabled = false;
            pb5.Enabled = false;    
            pb6.Enabled = false;
            pb7.Enabled = false;
            pb8.Enabled = false;
            pb9.Enabled = false;
            lblTurn.Text = "Game Over";
            if (TheWinner == "Player1")
                MessageBox.Show("The winner is Player1", "Winner Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (TheWinner == "Player2")
                MessageBox.Show("The winner is Player2", "Winner Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Draw", "Winner Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        bool isPlayerN_Winner(string PlayerN)
        {
            if ((pb1.Tag.ToString() == PlayerN && pb2.Tag.ToString() == PlayerN && pb3.Tag.ToString() == PlayerN))
            {
                pb1.BackColor = Color.Green;
                pb2.BackColor = Color.Green;
                pb3.BackColor = Color.Green;
                return true;
            }
            else if (pb4.Tag.ToString() == PlayerN && pb5.Tag.ToString() == PlayerN && pb6.Tag.ToString() == PlayerN)
            {
                pb4.BackColor = Color.Green;
                pb5.BackColor = Color.Green;
                pb6.BackColor = Color.Green;
                return true;
            }
            else if (pb7.Tag.ToString() == PlayerN && pb8.Tag.ToString() == PlayerN && pb9.Tag.ToString() == PlayerN)
            {
                pb7.BackColor = Color.Green;
                pb8.BackColor = Color.Green;
                pb9.BackColor = Color.Green;
                return true;
            }
            else if (pb1.Tag.ToString() == PlayerN && pb4.Tag.ToString() == PlayerN && pb7.Tag.ToString() == PlayerN)
            {
                pb1.BackColor = Color.Green;
                pb4.BackColor = Color.Green;
                pb7.BackColor = Color.Green;
                return true;
            }
            else if (pb2.Tag.ToString() == PlayerN && pb5.Tag.ToString() == PlayerN && pb8.Tag.ToString() == PlayerN)
            {
                pb2.BackColor = Color.Green;
                pb5.BackColor = Color.Green;
                pb8.BackColor = Color.Green;
                return true;
            }
            else if (pb3.Tag.ToString() == PlayerN && pb6.Tag.ToString() == PlayerN && pb9.Tag.ToString() == PlayerN)
            {
                pb3.BackColor = Color.Green;
                pb6.BackColor = Color.Green;
                pb9.BackColor = Color.Green;
                return true;
            }
            else if (pb1.Tag.ToString() == PlayerN && pb5.Tag.ToString() == PlayerN && pb9.Tag.ToString() == PlayerN)
            {
                pb1.BackColor = Color.Green;
                pb5.BackColor = Color.Green;
                pb9.BackColor = Color.Green;
                return true;
            }
            else if (pb3.Tag.ToString() == PlayerN && pb5.Tag.ToString() == PlayerN && pb7.Tag.ToString() == PlayerN)
            {
                pb3.BackColor = Color.Green;
                pb5.BackColor = Color.Green;
                pb7.BackColor = Color.Green;
                return true;
            }
            else
                return false;
              
        }
        void GameStatue(int count)
        {

            if (isPlayerN_Winner("1"))
            {
                lblWinner.Text = "Player1";
                EndGame("Player1");
                
            }
            else if (isPlayerN_Winner("2"))
            {
                lblWinner.Text = "Player2";
                EndGame("Player2");
            }
            else if(count == 9)
            {

                lblWinner.Text = "Draw";
                EndGame();
            }
        }
       
        void PlayerAnswer(PictureBox pb )
        {
            
            if (pb.Tag.ToString() == "0")
            {
                
                clsCount.count++;
                if (lblTurn.Text == "Player1")
                {
                    pb.Image = Resources.X;
                    pb.Tag = 1;
                    lblTurn.Text = "Player2";

                }
                else
                {
                    pb.Image = Resources.O;
                    pb.Tag = 2;
                    lblTurn.Text = "Player1";
                }
                GameStatue(clsCount.count);

                
                    
            }
            
        }

        void Restart()
        {

            pb1.Tag = 0;
            pb2.Tag = 0;
            pb3.Tag = 0;
            pb4.Tag = 0;
            pb5.Tag = 0;
            pb6.Tag = 0;
            pb7.Tag = 0;
            pb8.Tag = 0;
            pb9.Tag = 0;

            pb1.Enabled = true;
            pb2.Enabled = true;
            pb3.Enabled = true;
            pb4.Enabled = true;
            pb5.Enabled = true;
            pb6.Enabled = true;
            pb7.Enabled = true;
            pb8.Enabled = true;
            pb9.Enabled = true;


            pb1.BackColor = Color.Transparent;
            pb2.BackColor = Color.Transparent;
            pb3.BackColor = Color.Transparent;
            pb4.BackColor = Color.Transparent;
            pb5.BackColor = Color.Transparent;
            pb6.BackColor = Color.Transparent;
            pb7.BackColor = Color.Transparent;
            pb8.BackColor = Color.Transparent;
            pb9.BackColor = Color.Transparent;


            pb1.Image = Resources.question_mark_96;
            pb2.Image = Resources.question_mark_96;
            pb3.Image = Resources.question_mark_96;
            pb4.Image = Resources.question_mark_96;
            pb5.Image = Resources.question_mark_96;
            pb6.Image = Resources.question_mark_96;
            pb7.Image = Resources.question_mark_96;
            pb8.Image = Resources.question_mark_96; 
            pb9.Image = Resources.question_mark_96;

            clsCount.count = 0;
            lblTurn.Text = "Player1";

        }
        private void PaintCheap(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen WhitePen = new Pen(white);
            WhitePen.Width = 10;

            WhitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            WhitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(WhitePen, 250, 200, 700, 200);
            e.Graphics.DrawLine(WhitePen, 250, 320, 700, 320);
            e.Graphics.DrawLine(WhitePen, 400, 120, 400, 420);
            e.Graphics.DrawLine(WhitePen, 550, 120, 550, 420);


        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pb1_MouseClick(object sender, MouseEventArgs e)
        {
            PlayerAnswer(pb1);
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            PlayerAnswer(pb2);
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            PlayerAnswer(pb3);
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            PlayerAnswer(pb4);
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            PlayerAnswer(pb5);
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            PlayerAnswer(pb6);
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            PlayerAnswer(pb7);
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            PlayerAnswer(pb8);
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            PlayerAnswer(pb9);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }
}
