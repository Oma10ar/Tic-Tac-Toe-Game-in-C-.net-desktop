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

        struct Game
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
                
                Game.count++;
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
                GameStatue(Game.count);

                
                    
            }
            
        }

        void Restart()
        {
            PictureBox[] pictureBoxes = { pb1 ,  pb2 , pb3 , pb4 , pb5 , pb6 , pb7 , pb8 , pb9 };



            foreach (PictureBox pb in pictureBoxes)
            {
                pb.Tag = 0;
                pb.Enabled = true;
                pb.BackColor = Color.Transparent;
                pb.Image = Resources.question_mark_96;

            }

       


            

        
            Game.count = 0;
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

       
    
        private void pb_MouseClick(object sender, MouseEventArgs e)
        {
            PlayerAnswer((PictureBox) sender);
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
