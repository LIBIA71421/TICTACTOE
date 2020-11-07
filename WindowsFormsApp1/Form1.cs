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
    public partial class Form1 : Form
    {
        TICTACTOE game; 
        public Form1()
        {
            InitializeComponent();
            game = new TICTACTOE();
            game.WinnerFound += Game_WinnerFound;
            game.LoadedGame += Game_LoadedGame;
        }
        private void Game_LoadedGame(string[,] data)
        {
            btn_00.Text = data[0, 0];
            btn_01.Text = data[0, 1];
            btn_02.Text = data[0, 2];
            btn_10.Text = data[1, 0];
            btn_11.Text = data[1, 1];
            btn_12.Text = data[1, 2];
            btn_20.Text = data[2, 0];
            btn_21.Text = data[2, 1];
            btn_22.Text = data[2, 2];
        }
        private void Game_WinnerFound(string Winner)
        {
            MessageBox.Show(Winner + " Ha ganado el juego");
        }

        String[,] model = new string[3, 3];      
        private void button1_Click(object sender, EventArgs e)
        {
            if (!(sender is Button)) return;           var btn = (Button)sender;
            int row = 0;            int col = 0;
            string[] rowcol = btn.Tag.ToString().Split(',');
            row = Convert.ToInt32(rowcol[0]);
            col = Convert.ToInt32(rowcol[1]);

            btn.Text = game.CurrentGamer;
            game.Play(row, col);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PUZZLE est = new PUZZLE();
            est.ShowDialog();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //"C:\\Users\\HP\\AppData\\Roaming"
            game.Save(folder + @"\"+ "Game.txt");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            game.Open(folder + @"\" + "Game.txt");
        }
    }
}
