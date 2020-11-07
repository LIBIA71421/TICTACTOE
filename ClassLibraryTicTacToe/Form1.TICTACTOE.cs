using System;
using System.IO;

namespace WindowsFormsApp1
{
    public class TICTACTOE
    {
        private string[,] model = new string[3, 3];
        public TICTACTOE()
        {
            CurrentGamer = "X";
        }
        public string CurrentGamer { get; private set; }

        public delegate void WinnerDelegate(string Winner);
        public event WinnerDelegate WinnerFound;
        private void OnWinnerFound(string Winner)
        {
            if(WinnerFound != null)
            {
                WinnerFound(Winner);
            }
        }
        public delegate void LoadedGameDelegate(string[,] data);
        public event LoadedGameDelegate LoadedGame;
        private void OnLoadedGame(string[,] data)
        {
            if (LoadedGame != null)
            {
                LoadedGame(data);
            }
        }

        public void Save(string filename)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filename);
                var line = string.Empty;    
                for(int i = 0; i < 3; i++)
                {
                    for(int j =0; j < 3; j++)
                    {
                        line = line + ":" +model[i,j] ;
                    }
                }
                line = line + "," + CurrentGamer;
                sw.WriteLine(line);
                sw.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: ", ex.Message);
            }
        }

        public void Open(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            var line = lines[0];
            var componets = line.Split(',');
            var vector = componets[0].Split(':');
            CurrentGamer = componets[1];
            var counter = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    model[i, j] = vector[counter];
                    counter++;
                }
            }
            OnLoadedGame(model);
        }
        public void Play(int row, int col)
        {
            model[row, col] = CurrentGamer;
            var Winner = GetWinner(CurrentGamer);
            if (!string.IsNullOrEmpty(Winner))
            {
                OnWinnerFound(Winner);
            }

            if (CurrentGamer == "X")
            { CurrentGamer = "0"; }
            else
            { CurrentGamer = "X"; }
        }
        public string GetWinner(string gamer)
        {
            if (model[0, 0] != null && model[0, 1] != null && model[0, 2] != null && model[0, 0] == model[0, 1] && model[0, 1] == model[0, 2])
            { return gamer; }///////////////////////////////////////////////////2
            else if (model[1, 0] != null && model[1, 1] != null && model[1, 2] != null && model[1, 0] == model[1, 1] && model[1, 1] == model[1, 2])
            { return gamer; }////////////////////////////////////////////////////////3
            else if (model[2, 0] != null && model[2, 1] != null && model[2, 2] != null && model[2, 0] == model[2, 1] && model[2, 1] == model[2, 2])
            { return gamer; }


            else if (model[0, 0] != null && model[1, 0] != null && model[2, 0] != null && model[0, 0] == model[1, 0] && model[1, 0] == model[2, 0])
            { return gamer; }//////////////////////////////////////////////////////
            else if (model[0, 1] != null && model[1, 1] != null && model[2, 1] != null && model[0, 1] == model[1, 1] && model[1, 1] == model[2, 1])
            { return gamer; }/////////////////////////////////////////////////////
            else if (model[0, 2] != null && model[1, 2] != null && model[2, 2] != null && model[0, 2] == model[1, 2] && model[1, 2] == model[2, 2])
            { return gamer; }


            else if (model[0, 0] != null && model[1, 1] != null && model[2, 2] != null && model[0, 0] == model[1, 1] && model[1, 1] == model[2, 2])
            { return gamer; }//////////////////////////////////////////////////////
            else if (model[0, 2] != null && model[1, 1] != null && model[2, 0] != null && model[0, 2] == model[1, 1] && model[1, 1] == model[2, 0])
            { return gamer; }

            return null;
        }
    }
}
