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
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void PlayerPlayerBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Game game = new Game();
            game.GameMode = 1;
            SizePage size = new SizePage();
            size.ShowDialog();
            Close();
        }

        private void PlayerAiBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Game game = new Game();
            game.GameMode = 2;
            SizePage size = new SizePage();
            size.ShowDialog();
            Close();
        }

        private void AiAIBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Game game = new Game();
            game.GameMode = 3;
            SizePage size = new SizePage();
            size.ShowDialog();
            Close();
        }
    }
}
