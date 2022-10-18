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
    public partial class Game : Form
    {
        List<List<Button>> buttons = new List<List<Button>>();
        public int GameMode { get; set; }
        public int GameSize { get; set; }
        private bool _xTurn = true;
        private bool _win = false;

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(600, 650);
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            for (int i = 0; i < GameSize; i++)
            {
                buttons.Add(new List<Button>());
                for (int j = 0; j < GameSize; j++)
                {
                    buttons[i].Add(new Button());
                    if (GameSize == 3)
                    {
                        buttons[i][j].Location = new Point(i * 200, j * 200 + 50);
                        buttons[i][j].Size = new Size(200, 200);
                        buttons[i][j].Name = $"button{i}{j}";
                        buttons[i][j].Font = new Font(buttons[i][j].Font.FontFamily, 100, buttons[i][j].Font.Style);
                        buttons[i][j].MouseClick += new MouseEventHandler(ButtonCLick);
                        this.Controls.Add(buttons[i][j]);
                    }
                    else
                    {
                        buttons[i][j].Location = new Point(i * 120, j * 120 + 50);
                        buttons[i][j].Size = new Size(120, 120);
                        buttons[i][j].Name = $"button{i}{j}";
                        buttons[i][j].Font = new Font(buttons[i][j].Font.FontFamily, 50, buttons[i][j].Font.Style);
                        buttons[i][j].MouseClick += new MouseEventHandler(ButtonCLick);
                        this.Controls.Add(buttons[i][j]);
                    }
                }
            }
        }

        private void ButtonCLick(object sender, MouseEventArgs e)
        {
            int i = Int32.Parse((sender as Button).Name[6].ToString());
            int j = Int32.Parse((sender as Button).Name[7].ToString());
            if (_xTurn)
            {
                buttons[i][j].Text = "X";
                buttons[i][j].Enabled = false;
                _xTurn = false;
            }
            else
            {
                buttons[i][j].Text = "O";
                buttons[i][j].Enabled = false;
                _xTurn = true;
            }
            this.CheckWin();
        }

        private void CheckWin()
        {
            List<string> line = new List<string>();
            //проверка горизонталей
            for (int i = 0; i < GameSize; i++)
            {
                for (int j = 0; j < GameSize; j++)
                {
                    line.Add(buttons[j][i].Text);
                }
                if ((line.All(x => x == "X")) || (line.All(o => o == "O")))
                {
                    _win = true;
                    DisableButtons();
                }
                line.Clear();
            }
            //проверка вертикалей
            for (int i = 0; i < GameSize; i++)
            {
                for (int j = 0; j < GameSize; j++)
                {
                    line.Add(buttons[i][j].Text);
                }
                if ((line.All(x => x == "X")) || (line.All(o => o == "O")))
                {
                    _win = true;
                    DisableButtons();
                }
                line.Clear();
            }
            //проверка диагоналей
            for (int i = 0; i < GameSize; i++)
            {
                line.Add(buttons[i][i].Text);
            }
            if ((line.All(x => x == "X")) || (line.All(o => o == "O")))
            {
                _win = true;
                DisableButtons();
            }
            line.Clear();
            for (int i = 0; i < GameSize; i++)
            {
                line.Add(buttons[i][GameSize - (i + 1)].Text);
            }
            if ((line.All(x => x == "X")) || (line.All(o => o == "O")))
            {
                _win = true;
                DisableButtons();
            }
            line.Clear();
            //в случае победы
            if (_win)
            {
                if (_xTurn) MessageBox.Show("Победили нолики");
                else MessageBox.Show("Победили крестики");
            }
        }

        private void DisableButtons()
        {
            for (int i = 0; i < GameSize; i++)
            {
                for (int j = 0; j < GameSize; j++)
                {
                    buttons[i][j].Enabled = false;
                }
            }
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            Hide();
            StartPage startPage = new StartPage();
            startPage.ShowDialog();
            Close();
        }
    }
}
