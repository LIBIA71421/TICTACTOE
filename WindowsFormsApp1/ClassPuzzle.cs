using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ClassPuzzle
    {
        private string[,] model = new string[3, 3];
        public ClassPuzzle()
        {
        }
        public string CurrentGamer { get; private set; }

        public delegate void WinnerDelegate(string Winner);
        public event WinnerDelegate WinnerFound;
        private void OnWinnerFound(string Winner)
        {
                WinnerFound(Winner);        }
        public delegate void LoadedGameDelegate(string[,] data);
        public event LoadedGameDelegate LoadedGame;
        private void OnLoadedGame(string[,] data)
        {                LoadedGame(data);        }
       
        public void Play(string Winner)
        {
            if (!string.IsNullOrEmpty(Winner))
            {
                OnWinnerFound(Winner);

            }
        }
    }
}
