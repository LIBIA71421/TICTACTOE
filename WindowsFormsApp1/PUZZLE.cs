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
    public partial class PUZZLE : Form
    {
        public PUZZLE()
        {
            InitializeComponent();
        }
        int movesNumber = 0, labelIndex = 0;
        private void shuffleButtons()
        {
            List<int> labelList = new List<int>();
            Random rand = new Random();
            foreach (Button btn in this.pnl.Controls)
            {
                while (labelList.Contains(labelIndex))
                    labelIndex = rand.Next(9);

                btn.Text = (labelIndex == 0) ? "" : labelIndex + "";
                btn.BackColor = (btn.Text == "") ? Color.White : Color.FromKnownColor(KnownColor.ControlLight);
                labelList.Add(labelIndex);
            }
        }
        private void swapLabel(Object sender,EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "")     return;

            Button whiteBtn = null;
            foreach(Button bt in this.pnl.Controls)
            {
                if(bt.Text == "")
                {
                    whiteBtn = bt;
                    break;
                }
            }
            if(btn.TabIndex == (whiteBtn.TabIndex - 1) || btn.TabIndex == (whiteBtn.TabIndex - 3) || btn.TabIndex == (whiteBtn.TabIndex + 1) || btn.TabIndex == (whiteBtn.TabIndex + 3))
            {
                whiteBtn.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
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
            foreach(Button btn in this.pnl.Controls)
            {
                if(btn.Text != "" && Convert.ToInt16(btn.Text) != index)
                {
                    return;
                }
                index++;
            }
            MessageBox.Show("Has ganado en: " + movesNumber + "movimientos :)...");
        }

        private void J_Click(object sender, EventArgs e)
        {
            movesNumber = 0;
            labelIndex = 0;
            shuffleButtons();
        }

        private void PUZZLE_Load(object sender, EventArgs e)
        {
            shuffleButtons();
        }

        private void SIG_Click(object sender, EventArgs e)
        {
            this.Hide();
            Puzzle2 est = new Puzzle2();
            est.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 est = new Form1();
            est.ShowDialog();

        }
    }
}
