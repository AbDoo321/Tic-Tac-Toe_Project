using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Project.Properties;

namespace Tic_Tac_Toe_Project
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
       

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Pen Pen = new Pen(Color.White, 6);
            short d = 150;
            short x = 740;
            short y = 120;
            e.Graphics.DrawLine(Pen, x, y, x, y + 3 * d);
            e.Graphics.DrawLine(Pen, x + d, y, x + d, y + 3 * d);

            e.Graphics.DrawLine(Pen, x - d, y + d, x + 2 * d, y + d);
            e.Graphics.DrawLine(Pen, x - d, y + 2 * d, x + 2 * d, y + 2 * d);


        }

   

        enum enWinner
        {
            GameInProgress, enPlayer1, enPlayer2, enDraw
        }
        enum enPlayerTurn
        {
            Player1Turn, Player2Turn
        }
        struct stGameStatus
        {
            public enWinner Winner;
            public bool isGameOver;
            public short TurnsPlayedCount;
        }
        stGameStatus GameStatus;
        enPlayerTurn PlayerTurn = enPlayerTurn.Player1Turn;

        void RestartGame()
        {
            lblTurn.Text = "Player 1";
            lblWinner.Text = "In Progress";

            PlayerTurn = enPlayerTurn.Player1Turn;
            GameStatus.Winner = enWinner.GameInProgress;
            GameStatus.TurnsPlayedCount = 0;
            GameStatus.isGameOver = false;

            pb00.Image = Resources.question_mark_96;
            pb01.Image = Resources.question_mark_96;
            pb02.Image = Resources.question_mark_96;
            pb10.Image = Resources.question_mark_96;
            pb11.Image = Resources.question_mark_96;
            pb12.Image = Resources.question_mark_96;
            pb20.Image = Resources.question_mark_96;
            pb21.Image = Resources.question_mark_96;
            pb22.Image = Resources.question_mark_96;

            pb00.BackColor = Color.Transparent;
            pb01.BackColor = Color.Transparent;
            pb02.BackColor = Color.Transparent;
            pb10.BackColor = Color.Transparent;
            pb11.BackColor = Color.Transparent;
            pb12.BackColor = Color.Transparent;
            pb20.BackColor = Color.Transparent;
            pb21.BackColor = Color.Transparent;
            pb22.BackColor = Color.Transparent;

            pb00.Tag = "?";
            pb01.Tag = "?";
            pb02.Tag = "?";
            pb10.Tag = "?";
            pb11.Tag = "?";
            pb12.Tag = "?";
            pb20.Tag = "?";
            pb21.Tag = "?";
            pb22.Tag = "?";

            pb00.Enabled = true;
            pb01.Enabled = true;
            pb02.Enabled = true;
            pb10.Enabled = true;
            pb11.Enabled = true;
            pb12.Enabled = true;
            pb20.Enabled = true;
            pb21.Enabled = true;
            pb22.Enabled = true;
        }
        void EndGame()
        {
            lblTurn.Text = "Game Over!";
            switch (GameStatus.Winner)
            {
                case enWinner.enPlayer1:
                    lblWinner.Text = "Player 1";
                    break;
                case enWinner.enPlayer2:
                    lblWinner.Text = "Player 2";
                    break;
                default:
                    lblWinner.Text = "Draw";
                    break;
                    
            }
            MessageBox.Show("Game Over!", "GameOver",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void PlayTurn(object sender)
        {
            PictureBox pbSender = (PictureBox)sender;
            if (pbSender.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayerTurn.Player1Turn:
                        lblTurn.Text = "Player 2";
                        PlayerTurn = enPlayerTurn.Player2Turn;
                        ((PictureBox)sender).Image = Resources.X;
                        pbSender.Tag = "X";
                        GameStatus.TurnsPlayedCount++;
                        CheckWinner();
                        break;
                    case enPlayerTurn.Player2Turn:
                        lblTurn.Text = "Player 1";
                        PlayerTurn = enPlayerTurn.Player1Turn;
                        ((PictureBox)sender).Image = Resources.O;
                        pbSender.Tag = "O";
                        GameStatus.TurnsPlayedCount++;
                        CheckWinner();
                        break;
                    default:
                        break;
                }
            }


            if (GameStatus.TurnsPlayedCount == 9)
            {
                GameStatus.isGameOver = true;
                GameStatus.Winner = enWinner.enDraw;
                EndGame();
            }
        }
        
        bool CheckValues(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            if (pb1.Tag.ToString() != "?" && pb1.Tag.ToString() == pb2.Tag.ToString()
                                         && pb1.Tag.ToString() == pb3.Tag.ToString())
            {
                pb1.BackColor = Color.YellowGreen;
                pb2.BackColor = Color.YellowGreen;
                pb3.BackColor = Color.YellowGreen;

                pb00.Enabled = false;
                pb01.Enabled = false;
                pb02.Enabled = false;
                pb10.Enabled = false;
                pb11.Enabled = false;
                pb12.Enabled = false;
                pb20.Enabled = false;
                pb21.Enabled = false;
                pb22.Enabled = false;

                if (pb1.Tag.ToString() == "X")
                {
                        GameStatus.Winner = enWinner.enPlayer1;
                        GameStatus.isGameOver = true;
                        EndGame();
                        return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.enPlayer2;
                    GameStatus.isGameOver = true;
                    EndGame();
                    return true;
                }
                


            }
            GameStatus.isGameOver = false;
            return false;
        }


        void CheckWinner()
        {
            //checking Rows
            if (CheckValues(pb00, pb01, pb02))
                return;
            if (CheckValues(pb10, pb11, pb12))
                return;
            if (CheckValues(pb20, pb21, pb22))
                return;
            //checking Columns
            if (CheckValues(pb00, pb10, pb20))
                return;
            if (CheckValues(pb01, pb11, pb21))
                return;
            if (CheckValues(pb02, pb12, pb22))
                return;
            //checking Diagonals
            if (CheckValues(pb00, pb11, pb22))
                return;
            if (CheckValues(pb02, pb11, pb20))
                return;
        }

        
        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void pb_Click(object sender, EventArgs e)
        {
            PlayTurn((PictureBox)sender);
        }
        
    }
}
