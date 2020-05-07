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
        private TicTacToeEngine.TicTacToeEngine t = new TicTacToeEngine.TicTacToeEngine();

        public Form1()
        {
            InitializeComponent();
        }

        private void ResetGame()
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.Text = " ";
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button pressed = (Button)sender;
            String player = "O";
            int cell = 0;
            if (t.Status == TicTacToeEngine.TicTacToeEngine.GameStatus.PlayerOPlays) { player = "O"; }
            if (t.Status == TicTacToeEngine.TicTacToeEngine.GameStatus.PlayerXPlays) { player = "X"; }
            if (pressed.Name == "button1") cell = 1;
            if (pressed.Name == "button2") cell = 2;
            if (pressed.Name == "button3") cell = 3;
            if (pressed.Name == "button4") cell = 4;
            if (pressed.Name == "button5") cell = 5;
            if (pressed.Name == "button6") cell = 6;
            if (pressed.Name == "button7") cell = 7;
            if (pressed.Name == "button8") cell = 8;
            if (pressed.Name == "button9") cell = 9;
            if (t.ChooseCell(cell))
            {
                pressed.Text = player;
                if (t.Status == TicTacToeEngine.TicTacToeEngine.GameStatus.PlayerOWins)
                {
                    System.Windows.Forms.MessageBox.Show("Player O wins!");
                    t.Reset();
                    ResetGame();
                }
                else if (t.Status == TicTacToeEngine.TicTacToeEngine.GameStatus.PlayerXWins)
                {
                    System.Windows.Forms.MessageBox.Show("Player X wins!");
                    t.Reset();
                    ResetGame();
                }
                else if (t.Status == TicTacToeEngine.TicTacToeEngine.GameStatus.Tie)
                {
                    System.Windows.Forms.MessageBox.Show("Game is tied, nobody wins.");
                    t.Reset();
                    ResetGame();
                }
            }
        }
    }
}
