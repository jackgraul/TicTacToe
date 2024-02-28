/* TicTacToe.cs
 * Assignment 1
 * Revision History
 *      Jack Graul, 2023.09.15: Created
 *      Jack Graul, 2023.09.18: Added Code
 *      Jack Graul, 2023.09.20: Added Comments
 *      Jack Graul, 2023.09.28: Updated UI / Code
 */

using JGraulAssignment1.Properties;
using System.Media;

namespace JGraulAssignment1
{
    public partial class TicTacToe : Form
    {
        // Counter to determine if it is X or O's turn
        int turnCounter = 0;
        // 2D array to assign values for X / O
        int[,] gameGrid = new int[3, 3];
        // Soundplayer to play victory noise when a win happens
        private SoundPlayer player = new SoundPlayer(Resources.nflTheme);

        public TicTacToe()
        {
            InitializeComponent();
        }

        // Method to check for the 8 different possible win conditions
        // Upon detection of a win, a message box declares the winner and the game is reset
        public void CheckForWin()
        {
            // Row 1 Win Checks
            if (gameGrid[0, 0] == 1 && gameGrid[0, 1] == 1 && gameGrid[0, 2] == 1)
            {
                MessageBoxWithSound("X Wins!");
                ResetGame();
            }
            else if (gameGrid[0, 0] == 2 && gameGrid[0, 1] == 2 && gameGrid[0, 2] == 2)
            {
                MessageBoxWithSound("O Wins!");
                ResetGame();
            }

            // Row 2 Win Checks
            if (gameGrid[1, 0] == 1 && gameGrid[1, 1] == 1 && gameGrid[1, 2] == 1)
            {
                MessageBoxWithSound("X Wins!");
                ResetGame();
            }
            else if (gameGrid[1, 0] == 2 && gameGrid[1, 1] == 2 && gameGrid[1, 2] == 2)
            {
                MessageBoxWithSound("O Wins!");
                ResetGame();
            }

            // Row 3 Win Checks
            if (gameGrid[2, 0] == 1 && gameGrid[2, 1] == 1 && gameGrid[2, 2] == 1)
            {
                MessageBoxWithSound("X Wins!");
                ResetGame();
            }
            else if (gameGrid[2, 0] == 2 && gameGrid[2, 1] == 2 && gameGrid[2, 2] == 2)
            {
                MessageBoxWithSound("O Wins!");
                ResetGame();
            }

            // Column 1 Win Checks
            if (gameGrid[0, 0] == 1 && gameGrid[1, 0] == 1 && gameGrid[2, 0] == 1)
            {
                MessageBoxWithSound("X Wins!");
                ResetGame();
            }
            else if (gameGrid[0, 0] == 2 && gameGrid[1, 0] == 2 && gameGrid[2, 0] == 2)
            {
                MessageBoxWithSound("O Wins!");
                ResetGame();
            }

            // Column 2 Win Checks
            if (gameGrid[0, 1] == 1 && gameGrid[1, 1] == 1 && gameGrid[2, 1] == 1)
            {
                MessageBoxWithSound("X Wins!");
                ResetGame();
            }
            else if (gameGrid[0, 1] == 2 && gameGrid[1, 1] == 2 && gameGrid[2, 1] == 2)
            {
                MessageBoxWithSound("O Wins!");
                ResetGame();
            }

            // Column 3 Win Checks
            if (gameGrid[0, 2] == 1 && gameGrid[1, 2] == 1 && gameGrid[2, 2] == 1)
            {
                MessageBoxWithSound("X Wins!");
                ResetGame();
            }
            else if (gameGrid[0, 2] == 2 && gameGrid[1, 2] == 2 && gameGrid[2, 2] == 2)
            {
                MessageBoxWithSound("O Wins!");
                ResetGame();
            }

            // Diagonal Win Check 1
            if (gameGrid[0, 0] == 1 && gameGrid[1, 1] == 1 && gameGrid[2, 2] == 1)
            {
                MessageBoxWithSound("X Wins!");
                ResetGame();
            }
            else if (gameGrid[0, 0] == 2 && gameGrid[1, 1] == 2 && gameGrid[2, 2] == 2)
            {
                MessageBoxWithSound("O Wins!");
                ResetGame();
            }

            // Diagonal Win Check 2
            if (gameGrid[0, 2] == 1 && gameGrid[1, 1] == 1 && gameGrid[2, 0] == 1)
            {
                MessageBoxWithSound("X Wins!");
                ResetGame();
            }
            else if (gameGrid[0, 2] == 2 && gameGrid[1, 1] == 2 && gameGrid[2, 0] == 2)
            {
                MessageBoxWithSound("O Wins!");
                ResetGame();
            }

            // Tie Check
            else
            {
                // If no win condition has been achieved and the grid has been filled i.e. 9 turns
                // have taken place, a tie is declared and the game is reset
                if (turnCounter == 9)
                {
                    MessageBox.Show("It's A Tie!");
                    ResetGame();
                }
            }
        }

        // A method to reset the game and play again
        private void ResetGame()
        {
            // Reset the tiles
            ResetTiles();
            // Clear 2D array
            Array.Clear(gameGrid);
            // Reset turnCounter
            turnCounter = 0;
            // Reset lblTurn
            lblTurn.Text = "X's Turn";
            // Stops Soundplayer
            player.Stop();
        }

        // A method to reset the tile images and re-enable the tiles in order to play again
        private void ResetTiles()
        {
            tile1.Image = null;
            tile2.Image = null;
            tile3.Image = null;
            tile4.Image = null;
            tile5.Image = null;
            tile6.Image = null;
            tile7.Image = null;
            tile8.Image = null;
            tile9.Image = null;

            tile1.Enabled = true;
            tile2.Enabled = true;
            tile3.Enabled = true;
            tile4.Enabled = true;
            tile5.Enabled = true;
            tile6.Enabled = true;
            tile7.Enabled = true;
            tile8.Enabled = true;
            tile9.Enabled = true;
        }

        // A method to add sound for messageboxes
        private void MessageBoxWithSound(string msg)
        {
            player.Play();
            MessageBox.Show(msg);
        }

        // Tile Clicker Handler
        private void TileClick(object sender, EventArgs e)
        {
            PictureBox clickedTile = sender as PictureBox;

            tile1.Tag = 0;
            tile2.Tag = 1;
            tile3.Tag = 2;
            tile4.Tag = 3;
            tile5.Tag = 4;
            tile6.Tag = 5;
            tile7.Tag = 6;
            tile8.Tag = 7;
            tile9.Tag = 8;

            if (clickedTile != null)
            {
                int rowIndex = (int)clickedTile.Tag / gameGrid.GetLength(1);
                int colIndex = (int)clickedTile.Tag % gameGrid.GetLength(1);

                if (gameGrid[rowIndex, colIndex] == 0)
                {
                    if (turnCounter % 2 == 0)
                    {
                        clickedTile.Image = JGraulAssignment1.Properties.Resources.x;
                        lblTurn.Text = "O's turn";
                        gameGrid[rowIndex, colIndex] = 1;
                    }
                    else
                    {
                        clickedTile.Image = JGraulAssignment1.Properties.Resources.o;
                        lblTurn.Text = "X's turn";
                        gameGrid[rowIndex, colIndex] = 2;
                    }

                    clickedTile.Enabled = false;
                    turnCounter++;
                    CheckForWin();
                }
            }
        }


        // Tile click handlers.
        // Depending on the turnCounter assign an X or O image and update the 2D array and lblTurn accordingly.
        // The turnCounter is then incremented and the tile is disabled so it cannot be clicked again
        // and a win check is completed
        private void tile1_Click(object sender, EventArgs e)
        {
            if (turnCounter % 2 == 0)
            {
                tile1.Image = JGraulAssignment1.Properties.Resources.x;
                lblTurn.Text = "O's turn";
                gameGrid[0, 0] = 1;
                tile1.Enabled = false;
                turnCounter++;
                CheckForWin();
            }
            else if (turnCounter % 2 != 0)
            {
                tile1.Image = JGraulAssignment1.Properties.Resources.o;
                lblTurn.Text = "X's turn";
                gameGrid[0, 0] = 2;
                tile1.Enabled = false;
                turnCounter++;
                CheckForWin();
            }
        }

        private void tile2_Click(object sender, EventArgs e)
        {
            if (turnCounter % 2 == 0)
            {
                tile2.Image = JGraulAssignment1.Properties.Resources.x;
                lblTurn.Text = "O's turn";
                gameGrid[0, 1] = 1;
                tile2.Enabled = false;
                turnCounter++;
                CheckForWin();
            }
            else if (turnCounter % 2 != 0)
            {
                tile2.Image = JGraulAssignment1.Properties.Resources.o;
                lblTurn.Text = "X's turn";
                gameGrid[0, 1] = 2;
                tile2.Enabled = false;
                turnCounter++;
                CheckForWin();
            }
        }

        private void tile3_Click(object sender, EventArgs e)
        {
            if (turnCounter % 2 == 0)
            {
                tile3.Image = JGraulAssignment1.Properties.Resources.x;
                lblTurn.Text = "O's turn";
                gameGrid[0, 2] = 1;
                tile3.Enabled = false;
                turnCounter++;
                CheckForWin();
            }
            else if (turnCounter % 2 != 0)
            {
                tile3.Image = JGraulAssignment1.Properties.Resources.o;
                lblTurn.Text = "X's turn";
                gameGrid[0, 2] = 2;
                tile3.Enabled = false;
                turnCounter++;
                CheckForWin();
            }
        }

        private void tile4_Click(object sender, EventArgs e)
        {
            if (turnCounter % 2 == 0)
            {
                tile4.Image = JGraulAssignment1.Properties.Resources.x;
                lblTurn.Text = "O's turn";
                gameGrid[1, 0] = 1;
                tile4.Enabled = false;
                turnCounter++;
                CheckForWin();
            }
            else if (turnCounter % 2 != 0)
            {
                tile4.Image = JGraulAssignment1.Properties.Resources.o;
                lblTurn.Text = "X's turn";
                gameGrid[1, 0] = 2;
                tile4.Enabled = false;
                turnCounter++;
                CheckForWin();
            }
        }

        private void tile5_Click(object sender, EventArgs e)
        {
            if (turnCounter % 2 == 0)
            {
                tile5.Image = JGraulAssignment1.Properties.Resources.x;
                lblTurn.Text = "O's turn";
                gameGrid[1, 1] = 1;
                tile5.Enabled = false;
                turnCounter++;
                CheckForWin();
            }
            else if (turnCounter % 2 != 0)
            {
                tile5.Image = JGraulAssignment1.Properties.Resources.o;
                lblTurn.Text = "X's turn";
                gameGrid[1, 1] = 2;
                tile5.Enabled = false;
                turnCounter++;
                CheckForWin();
            }
        }

        private void tile6_Click(object sender, EventArgs e)
        {
            if (turnCounter % 2 == 0)
            {
                tile6.Image = JGraulAssignment1.Properties.Resources.x;
                lblTurn.Text = "O's turn";
                gameGrid[1, 2] = 1;
                tile6.Enabled = false;
                turnCounter++;
                CheckForWin();
            }
            else if (turnCounter % 2 != 0)
            {
                tile6.Image = JGraulAssignment1.Properties.Resources.o;
                lblTurn.Text = "X's turn";
                gameGrid[1, 2] = 2;
                tile6.Enabled = false;
                turnCounter++;
                CheckForWin();
            }
        }

        private void tile7_Click(object sender, EventArgs e)
        {
            if (turnCounter % 2 == 0)
            {
                tile7.Image = JGraulAssignment1.Properties.Resources.x;
                lblTurn.Text = "O's turn";
                gameGrid[2, 0] = 1;
                tile7.Enabled = false;
                turnCounter++;
                CheckForWin();
            }
            else if (turnCounter % 2 != 0)
            {
                tile7.Image = JGraulAssignment1.Properties.Resources.o;
                lblTurn.Text = "X's turn";
                gameGrid[2, 0] = 2;
                tile7.Enabled = false;
                turnCounter++;
                CheckForWin();
            }
        }

        private void tile8_Click(object sender, EventArgs e)
        {
            if (turnCounter % 2 == 0)
            {
                tile8.Image = JGraulAssignment1.Properties.Resources.x;
                lblTurn.Text = "O's turn";
                gameGrid[2, 1] = 1;
                tile8.Enabled = false;
                turnCounter++;
                CheckForWin();
            }
            else if (turnCounter % 2 != 0)
            {
                tile8.Image = JGraulAssignment1.Properties.Resources.o;
                lblTurn.Text = "X's turn";
                gameGrid[2, 1] = 2;
                tile8.Enabled = false;
                turnCounter++;
                CheckForWin();
            }
        }

        private void tile9_Click(object sender, EventArgs e)
        {
            if (turnCounter % 2 == 0)
            {
                tile9.Image = JGraulAssignment1.Properties.Resources.x;
                lblTurn.Text = "O's turn";
                gameGrid[2, 2] = 1;
                tile9.Enabled = false;
                turnCounter++;
                CheckForWin();
            }
            else if (turnCounter % 2 != 0)
            {
                tile9.Image = JGraulAssignment1.Properties.Resources.o;
                lblTurn.Text = "X's turn";
                gameGrid[2, 2] = 2;
                tile9.Enabled = false;
                turnCounter++;
                CheckForWin();
            }
        }
    }
}