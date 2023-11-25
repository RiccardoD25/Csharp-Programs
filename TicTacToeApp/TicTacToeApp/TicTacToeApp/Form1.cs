using System.Diagnostics.Eventing.Reader;
using System.Security.Policy;

namespace TicTacToeApp
{
    public partial class Form1 : Form
    {

        public enum Player
        //Random X and O created with Player Y (CPU) to make the game interactive
        {
            X, O
        }
        Player currentPlayer;
        Random random = new Random();
        int playerWinCount = 0;
        int CPUwinCount = 0;
        private Color defaultBackColor;
        List<Button> buttons;


        public Form1()
        {
            InitializeComponent();
            NewGame();
        }

        private void Player2move(object sender, EventArgs e)
        {
            // Player Y (CPU) is assigned O for game play and allows for selected box back color to change to Dark Salmon
            // Laslty Player X cannot select same boxes as player Y to avoid over selecting and has timer set in place
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.DarkSalmon;
                buttons.RemoveAt(index);
                CheckGame();
                Player2Timer.Stop();
            }
        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            // Player X is assigned X for game play and allows for selected box back color to change to cyan
            // Laslty Player Y (CPU) cannot select same boxes as player X to avoid over selecting and has timer set in place
            var button = (Button)sender;

            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.Cyan;
            buttons.Remove(button);
            CheckGame();
            Player2Timer.Start();
        }

        private void NewGame(object sender, EventArgs e)
        //Restarts the game to a new game state
        {
            NewGame();
            label1.Text = "Player X Wins: ";
            label2.Text = "Player Y Wins: ";
        }

        private void Exit(object sender, EventArgs e)
        //Closes the game application GUI
        {
            this.Close();
        }

        private void CheckGame()
        // This will check that Player X has selected either of the 9 boxes in Horizontal/Vertical/Diagonal
        // with 3 in a row for the game to end with a winner
        {
            if (button3.Text == "X" && button4.Text == "X" && button5.Text == "X"
                || button6.Text == "X" && button7.Text == "X" && button8.Text == "X"
                || button9.Text == "X" && button10.Text == "X" && button11.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button4.Text == "X" && button7.Text == "X" && button10.Text == "X"
                || button5.Text == "X" && button8.Text == "X" && button11.Text == "X"
                || button3.Text == "X" && button7.Text == "X" && button11.Text == "X"
                || button5.Text == "X" && button7.Text == "X" && button9.Text == "X"
                )
            {
                Player2Timer.Stop();
                MessageBox.Show("Player X Wins!", "Tic Tac Toe Game Says");
                playerWinCount++;
                label1.Text = "Player Wins: " + playerWinCount;
                NewGame();

            }
            // This will check that Player Y has selected either of the 9 boxes in Horizontal / Vertical / Diagonal
            // with 3 in a row for the game to end with a winner

            else if (button3.Text == "O" && button4.Text == "O" && button5.Text == "O"
                || button6.Text == "O" && button7.Text == "O" && button8.Text == "O"
                || button9.Text == "O" && button10.Text == "O" && button11.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button4.Text == "O" && button7.Text == "O" && button10.Text == "O"
                || button5.Text == "O" && button8.Text == "O" && button11.Text == "O"
                || button3.Text == "O" && button7.Text == "O" && button11.Text == "O"
                || button5.Text == "O" && button7.Text == "O" && button9.Text == "O"
                )
            {
                Player2Timer.Stop();
                MessageBox.Show("Player Y Wins!", "Tic Tac Toe Game Says");
                CPUwinCount++;
                label2.Text = "Player Wins: " + CPUwinCount;
                NewGame();

            }

        }
        private void NewGame()
        //List of 9 Boxes form the GUI which are considred buttons
        {
            buttons = new List<Button> { button3, button4, button5,
                button6, button7, button8, button9, button10, button11 };
            foreach (Button x in buttons)

            //Background color of all 9 boxes has been created but deafualts back to original color selected
            {
                x.Enabled = true;
                x.Text = "?";
                x.BackColor = defaultBackColor;
            }
        }

    }
}