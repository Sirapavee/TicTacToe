using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{

    public partial class Form1 : Form
    {

        private bool xTurn;
        private bool oTurn;
        private int btnCount = 0;
        private bool end;
        private int xScore = 0;
        private int oScore = 0;

        IDictionary<string, bool> buttonState = new Dictionary<String, bool>()
        {
            {"aIsClicked", false},
            {"bIsClicked", false},
            {"cIsClicked", false},
            {"dIsClicked", false},
            {"eIsClicked", false},
            {"fIsClicked", false},
            {"gIsClicked", false},
            {"hIsClicked", false},
            {"iIsClicked", false}
        };

        public Form1()
        {
            InitializeComponent();
            turnLabel.Text = "Who go first?";
            xScoreLabel.Text = String.Concat("X's Score : ", xScore);
            oScoreLabel.Text = String.Concat("O's Score : ", oScore);
        }

        private void Form1_Load(object sender, EventArgs j)
        {
            xTurn = true;
            oTurn = false;
            end = false;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs j)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void A_Click(object sender, EventArgs j)
        {
            if (xTurn && buttonState[buttonState.Keys.ElementAt(0)] == false)
            {
                turnLabel.Text = "O's Turn!";
                a.Text = "X";
                xTurn = false;
                oTurn = true;
                buttonState[buttonState.Keys.ElementAt(0)] = true;

                if (a.Text == b.Text && a.Text == c.Text && b.Text == c.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(a.Text + " Wins!!!");
                }
                else if (a.Text == d.Text && a.Text == g.Text && d.Text == g.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(a.Text + " Wins!!!");
                }
                else if(a.Text == e.Text && a.Text == i.Text && e.Text == i.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(a.Text + " Wins!!!");
                }
            }
            else if (oTurn && buttonState[buttonState.Keys.ElementAt(0)] == false)
            {
                turnLabel.Text = "X's Turn!";
                a.Text = "O";
                oTurn = false;
                xTurn = true;
                buttonState[buttonState.Keys.ElementAt(0)] = true;

                if (a.Text == b.Text && a.Text == c.Text && b.Text == c.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(a.Text + " Wins!!!");
                }
                else if (a.Text == d.Text && a.Text == g.Text && d.Text == g.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(a.Text + " Wins!!!");
                }
                else if (a.Text == e.Text && a.Text == i.Text && e.Text == i.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(a.Text + " Wins!!!");
                }
            }

            btnCount++;
            printScore();
            noWinner();
        }

        private void B_Click(object sender, EventArgs j)
        {
            if (xTurn && buttonState[buttonState.Keys.ElementAt(1)] == false)
            {
                turnLabel.Text = "O's Turn!";
                b.Text = "X";
                xTurn = false;
                oTurn = true;
                buttonState[buttonState.Keys.ElementAt(1)] = true;

                if (a.Text == b.Text && a.Text == c.Text && b.Text == c.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(b.Text + " Wins!!!");
                }
                else if(b.Text == e.Text && b.Text == h.Text && e.Text == h.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(b.Text + " Wins!!!");
                }
            }
            else if (oTurn && buttonState[buttonState.Keys.ElementAt(1)] == false)
            {
                turnLabel.Text = "X's Turn!";
                b.Text = "O";
                oTurn = false;
                xTurn = true;
                buttonState[buttonState.Keys.ElementAt(1)] = true;

                if (a.Text == b.Text && a.Text == c.Text && b.Text == c.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(b.Text + " Wins!!!");
                }
                else if (b.Text == e.Text && b.Text == h.Text && e.Text == h.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(b.Text + " Wins!!!");
                }
            }

            btnCount++;
            printScore();
            noWinner();
        }

        private void C_Click(object sender, EventArgs j)
        {
            if (xTurn && buttonState[buttonState.Keys.ElementAt(2)] == false)
            {
                turnLabel.Text = "O's Turn!";
                c.Text = "X";
                xTurn = false;
                oTurn = true;
                buttonState[buttonState.Keys.ElementAt(2)] = true;

                if (a.Text == b.Text && a.Text == c.Text && b.Text == c.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(c.Text + " Wins!!!");
                }
                else if (c.Text == f.Text && c.Text == i.Text && f.Text == i.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(c.Text + " Wins!!!");
                }
                else if (c.Text == e.Text && c.Text == g.Text && e.Text == g.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(c.Text + " Wins!!!");
                }
            }
            else if (oTurn && buttonState[buttonState.Keys.ElementAt(2)] == false)
            {
                turnLabel.Text = "X's Turn!";
                c.Text = "O";
                oTurn = false;
                xTurn = true;
                buttonState[buttonState.Keys.ElementAt(2)] = true;

                if (a.Text == b.Text && a.Text == c.Text && b.Text == c.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(c.Text + " Wins!!!");
                }
                else if (c.Text == f.Text && c.Text == i.Text && f.Text == i.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(c.Text + " Wins!!!");
                }
                else if (c.Text == e.Text && c.Text == g.Text && e.Text == g.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(c.Text + " Wins!!!");
                }
            }

            btnCount++;
            printScore();
            noWinner();
        }

        private void D_Click(object sender, EventArgs j)
        {
            if (xTurn && buttonState[buttonState.Keys.ElementAt(3)] == false)
            {
                turnLabel.Text = "O's Turn!";
                d.Text = "X";
                xTurn = false;
                oTurn = true;
                buttonState[buttonState.Keys.ElementAt(3)] = true;

                if (d.Text == a.Text && d.Text == g.Text && a.Text == g.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(d.Text + " Wins!!!");
                }
                else if (d.Text == f.Text && d.Text == e.Text && f.Text == e.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(d.Text + " Wins!!!");
                }
            }
            else if (oTurn && buttonState[buttonState.Keys.ElementAt(3)] == false)
            {
                turnLabel.Text = "X's Turn!";
                d.Text = "O";
                oTurn = false;
                xTurn = true;
                buttonState[buttonState.Keys.ElementAt(3)] = true;

                if (d.Text == a.Text && d.Text == g.Text && a.Text == g.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(d.Text + " Wins!!!");
                }
                else if (d.Text == f.Text && d.Text == e.Text && f.Text == e.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(d.Text + " Wins!!!");
                }
            }

            btnCount++;
            printScore();
            noWinner();
        }

        private void E_Click(object sender, EventArgs j)
        {
            if (xTurn && buttonState[buttonState.Keys.ElementAt(4)] == false)
            {
                turnLabel.Text = "O's Turn!";
                e.Text = "X";
                xTurn = false;
                oTurn = true;
                buttonState[buttonState.Keys.ElementAt(4)] = true;

                if (e.Text == b.Text && e.Text == h.Text && b.Text == h.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(e.Text + " Wins!!!");
                }
                else if (d.Text == f.Text && d.Text == e.Text && f.Text == e.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(e.Text + " Wins!!!");
                }
                else if (c.Text == e.Text && c.Text == g.Text && e.Text == g.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(e.Text + " Wins!!!");
                }
            }
            else if (oTurn && buttonState[buttonState.Keys.ElementAt(4)] == false)
            {
                turnLabel.Text = "X's Turn!";
                e.Text = "O";
                oTurn = false;
                xTurn = true;
                buttonState[buttonState.Keys.ElementAt(4)] = true;

                if (e.Text == b.Text && e.Text == h.Text && b.Text == h.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(e.Text + " Wins!!!");
                }
                else if (d.Text == f.Text && d.Text == e.Text && f.Text == e.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(e.Text + " Wins!!!");
                }
                else if (c.Text == e.Text && c.Text == g.Text && e.Text == g.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(e.Text + " Wins!!!");
                }
            }

            btnCount++;
            printScore();
            noWinner();
        }

        private void F_Click(object sender, EventArgs j)
        {
            if (xTurn && buttonState[buttonState.Keys.ElementAt(5)] == false)
            {
                turnLabel.Text = "O's Turn!";
                f.Text = "X";
                xTurn = false;
                oTurn = true;
                buttonState[buttonState.Keys.ElementAt(5)] = true;

                if (f.Text == c.Text && f.Text == i.Text && c.Text == i.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(f.Text + " Wins!!!");
                }
                else if (d.Text == f.Text && d.Text == e.Text && f.Text == e.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(f.Text + " Wins!!!");
                }
            }
            else if (oTurn && buttonState[buttonState.Keys.ElementAt(5)] == false)
            {
                turnLabel.Text = "X's Turn!";
                f.Text = "O";
                oTurn = false;
                xTurn = true;
                buttonState[buttonState.Keys.ElementAt(5)] = true;

                if (f.Text == c.Text && f.Text == i.Text && c.Text == i.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(f.Text + " Wins!!!");
                }
                else if (d.Text == f.Text && d.Text == e.Text && f.Text == e.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(f.Text + " Wins!!!");
                }
            }

            btnCount++;
            printScore();
            noWinner();
        }

        private void G_Click(object sender, EventArgs j)
        {
            if (xTurn && buttonState[buttonState.Keys.ElementAt(6)] == false)
            {
                turnLabel.Text = "O's Turn!";
                g.Text = "X";
                xTurn = false;
                oTurn = true;
                buttonState[buttonState.Keys.ElementAt(6)] = true;

                if (g.Text == h.Text && g.Text == i.Text && h.Text == i.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(g.Text + " Wins!!!");
                }
                else if (d.Text == a.Text && d.Text == g.Text && a.Text == g.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(g.Text + " Wins!!!");
                }
                else if (c.Text == e.Text && c.Text == g.Text && e.Text == g.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(g.Text + " Wins!!!");
                }
            }
            else if (oTurn && buttonState[buttonState.Keys.ElementAt(6)] == false)
            {
                turnLabel.Text = "X's Turn!";
                g.Text = "O";
                oTurn = false;
                xTurn = true;
                buttonState[buttonState.Keys.ElementAt(6)] = true;

                if (g.Text == h.Text && g.Text == i.Text && h.Text == i.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(g.Text + " Wins!!!");
                }
                else if (d.Text == a.Text && d.Text == g.Text && a.Text == g.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(g.Text + " Wins!!!");
                }
                else if (c.Text == e.Text && c.Text == g.Text && e.Text == g.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(g.Text + " Wins!!!");
                }
            }

            btnCount++;
            printScore();
            noWinner();
        }

        private void H_Click(object sender, EventArgs j)
        {
            if (xTurn && buttonState[buttonState.Keys.ElementAt(7)] == false)
            {
                turnLabel.Text = "O's Turn!";
                h.Text = "X";
                xTurn = false;
                oTurn = true;
                buttonState[buttonState.Keys.ElementAt(7)] = true;

                if (g.Text == h.Text && g.Text == i.Text && h.Text == i.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(h.Text + " Wins!!!");
                }
                else if (e.Text == b.Text && e.Text == h.Text && b.Text == h.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(h.Text + " Wins!!!");
                }
            }
            else if (oTurn && buttonState[buttonState.Keys.ElementAt(7)] == false)
            {
                turnLabel.Text = "X's Turn!";
                h.Text = "O";
                oTurn = false;
                xTurn = true;
                buttonState[buttonState.Keys.ElementAt(7)] = true;

                if (g.Text == h.Text && g.Text == i.Text && h.Text == i.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(h.Text + " Wins!!!");
                }
                else if (e.Text == b.Text && e.Text == h.Text && b.Text == h.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(h.Text + " Wins!!!");
                }
            }

            btnCount++;
            printScore();
            noWinner();
        }

        private void I_Click(object sender, EventArgs j)
        {
            if (xTurn && buttonState[buttonState.Keys.ElementAt(8)] == false)
            {
                turnLabel.Text = "O's Turn!";
                i.Text = "X";
                xTurn = false;
                oTurn = true;
                buttonState[buttonState.Keys.ElementAt(8)] = true;

                if (g.Text == h.Text && g.Text == i.Text && h.Text == i.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(i.Text + " Wins!!!");
                }
                else if (c.Text == f.Text && c.Text == i.Text && f.Text == i.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(i.Text + " Wins!!!");
                }
                else if (a.Text == e.Text && a.Text == i.Text && e.Text == i.Text)
                {
                    turnLabel.Text = "X Win!";
                    xScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(i.Text + " Wins!!!");
                }
            }
            else if (oTurn && buttonState[buttonState.Keys.ElementAt(8)] == false)
            {
                turnLabel.Text = "X's Turn!";
                i.Text = "O";
                oTurn = false;
                xTurn = true;
                buttonState[buttonState.Keys.ElementAt(8)] = true;

                if (g.Text == h.Text && g.Text == i.Text && h.Text == i.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(i.Text + " Wins!!!");
                }
                else if (c.Text == f.Text && c.Text == i.Text && f.Text == i.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(i.Text + " Wins!!!");
                }
                else if (a.Text == e.Text && a.Text == i.Text && e.Text == i.Text)
                {
                    turnLabel.Text = "O Win!";
                    oScore++;
                    end = true;
                    disableClick();
                    System.Windows.Forms.MessageBox.Show(i.Text + " Wins!!!");
                }
            }

            btnCount++;
            printScore();
            noWinner();
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs j)
        {
            turnLabel.Text = "Who go first?";
            xScoreLabel.Text = "X's Score : 0";
            oScoreLabel.Text = "O's Score : 0";
            xScore = 0;
            oScore = 0;

            xTurn = true;
            oTurn = false;

            a.Text = String.Empty;
            b.Text = String.Empty;
            c.Text = String.Empty;
            d.Text = String.Empty;
            e.Text = String.Empty;
            f.Text = String.Empty;
            g.Text = String.Empty;
            h.Text = String.Empty;
            i.Text = String.Empty;

            buttonState[buttonState.Keys.ElementAt(0)] = false;
            buttonState[buttonState.Keys.ElementAt(1)] = false;
            buttonState[buttonState.Keys.ElementAt(2)] = false;
            buttonState[buttonState.Keys.ElementAt(3)] = false;
            buttonState[buttonState.Keys.ElementAt(4)] = false;
            buttonState[buttonState.Keys.ElementAt(5)] = false;
            buttonState[buttonState.Keys.ElementAt(6)] = false;
            buttonState[buttonState.Keys.ElementAt(7)] = false;
            buttonState[buttonState.Keys.ElementAt(8)] = false;

            btnCount = 0;
        }

        public void disableClick()
        {
            for(int i = 0; i < buttonState.Count; i++)
            {
                buttonState[buttonState.Keys.ElementAt(i)] = true;
            }

        }

        private void printScore()
        {
            xScoreLabel.Text = String.Concat("X's Score : ", xScore);
            oScoreLabel.Text = String.Concat("O's Score : ", oScore);
        }

        private void Restart_Click(object sender, EventArgs j)
        {
            turnLabel.Text = "Who go first?";

            xTurn = true;
            oTurn = false;

            a.Text = String.Empty;
            b.Text = String.Empty;
            c.Text = String.Empty;
            d.Text = String.Empty;
            e.Text = String.Empty;
            f.Text = String.Empty;
            g.Text = String.Empty;
            h.Text = String.Empty;
            i.Text = String.Empty;

            buttonState[buttonState.Keys.ElementAt(0)] = false;
            buttonState[buttonState.Keys.ElementAt(1)] = false;
            buttonState[buttonState.Keys.ElementAt(2)] = false;
            buttonState[buttonState.Keys.ElementAt(3)] = false;
            buttonState[buttonState.Keys.ElementAt(4)] = false;
            buttonState[buttonState.Keys.ElementAt(5)] = false;
            buttonState[buttonState.Keys.ElementAt(6)] = false;
            buttonState[buttonState.Keys.ElementAt(7)] = false;
            buttonState[buttonState.Keys.ElementAt(8)] = false;

            btnCount = 0;
        }

        public void noWinner()
        {
            if(!end && btnCount == 9)
            {
                System.Windows.Forms.MessageBox.Show("No winner? Come on!");

                turnLabel.Text = "Who go first?";

                xTurn = true;
                oTurn = false;

                a.Text = String.Empty;
                b.Text = String.Empty;
                c.Text = String.Empty;
                d.Text = String.Empty;
                e.Text = String.Empty;
                f.Text = String.Empty;
                g.Text = String.Empty;
                h.Text = String.Empty;
                i.Text = String.Empty;

                buttonState[buttonState.Keys.ElementAt(0)] = false;
                buttonState[buttonState.Keys.ElementAt(1)] = false;
                buttonState[buttonState.Keys.ElementAt(2)] = false;
                buttonState[buttonState.Keys.ElementAt(3)] = false;
                buttonState[buttonState.Keys.ElementAt(4)] = false;
                buttonState[buttonState.Keys.ElementAt(5)] = false;
                buttonState[buttonState.Keys.ElementAt(6)] = false;
                buttonState[buttonState.Keys.ElementAt(7)] = false;
                buttonState[buttonState.Keys.ElementAt(8)] = false;

                btnCount = 0;
            }
        }
    }
}
