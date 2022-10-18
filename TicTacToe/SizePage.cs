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
    public partial class SizePage : Form
    {
        public SizePage()
        {
            InitializeComponent();
        }

        private void Btn3x3_Click(object sender, EventArgs e)
        {
            Hide();
            Game game = new Game();
            game.GameSize = 3;
            game.ShowDialog();
            Close();
        }

        private void Btn5x5_Click(object sender, EventArgs e)
        {
            Hide();
            Game game = new Game();
            game.GameSize = 5;
            game.ShowDialog();
            Close();
        }
    }
}
