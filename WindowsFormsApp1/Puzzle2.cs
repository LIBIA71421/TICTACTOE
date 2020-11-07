using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Puzzle2 : Form
    {
        ClassPuzzle gameP;
        int movesNumber = 0, labelIndex = 0;
        public Puzzle2()
        {
            InitializeComponent();
            gameP = new ClassPuzzle();
            gameP.WinnerFound += Game_WinnerFound;
            gameP.LoadedGame += Game_LoadedGame;
        }
        private void Game_LoadedGame(string[,] data)
        {
            //btn_00.Text = data[0, 0];
            //btn_01.Text = data[0, 1];
            //btn_02.Text = data[0, 2];
            //btn_10.Text = data[1, 0];
            //btn_11.Text = data[1, 1];
            //btn_12.Text = data[1, 2];
            //btn_20.Text = data[2, 0];
            //btn_21.Text = data[2, 1];
            //btn_22.Text = data[2, 2];

        }
        private void Game_WinnerFound(string Winner)
        {
            MessageBox.Show(Winner + " Ha ganado el juego");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PUZZLE est = new PUZZLE();
            est.ShowDialog();
        }
        private void swapLabel(Object sender, EventArgs e)
        {
            if (!(sender is Button)) return;            Button btn = (Button)sender;
            if (btn.Text == "") return;            Button whiteBtn = null;
            foreach (Button bt in this.pnl.Controls)
            {
                if (bt.Text == "")
                {
                    whiteBtn = bt;
                    break;
                }
            }
            if (btn.TabIndex == (whiteBtn.TabIndex - 1) || btn.TabIndex == (whiteBtn.TabIndex - 3) || btn.TabIndex == (whiteBtn.TabIndex + 1) || btn.TabIndex == (whiteBtn.TabIndex + 3))
            {
                whiteBtn.BackColor = Color.FromKnownColor(KnownColor.Cyan);
                btn.BackColor = Color.White;
                whiteBtn.Text = btn.Text;
                btn.Text = "";
                movesNumber++;
                lblNoOfMoves.Text = "Movimientos: " + movesNumber;
            }
            checkOrder();
        }
        private void checkOrder()
        {
            int index = 1;
            foreach (Button btn in this.pnl.Controls)
            {
                if (btn.Text != "" && Convert.ToInt16(btn.Text) != index)
                {
                    return;
                }   index++;
            }   MessageBox.Show("Has ganado en: " + movesNumber + "movimientos :)...");
        }
        private void shuffleButtons()
        {
            List<int> labelList = new List<int>();
            Random rand = new Random();
            foreach (Button btn in this.pnl.Controls)
            {
                while (labelList.Contains(labelIndex))
                    labelIndex = rand.Next(9);

                btn.Text = (labelIndex == 0) ? "" : labelIndex + "";
                btn.BackColor = (btn.Text == "") ? Color.White : Color.FromKnownColor(KnownColor.Cyan);
                labelList.Add(labelIndex);
            }
        }
        private void J_Click(object sender, EventArgs e)
        {
            movesNumber = 0;
            labelIndex = 0;
            shuffleButtons();
        }
        String[,] model = new string[3, 3];
        public string GetWinner(string gamer)
        {
            if (model[0, 0] == btn_00.Text && model[0, 1] == btn_01.Text && model[0, 2] == btn_02.Text && 
                model[1, 0] == btn_10.Text && model[1, 1] == btn_11.Text && model[1, 2] == btn_12.Text &&
                model[2, 0] == btn_20.Text && model[2, 1] == btn_21.Text && model[2, 2] == btn_22.Text)
            {
                gameP.Play(gamer);
                return gamer; 
            }

            return null;
        }

    }
}
