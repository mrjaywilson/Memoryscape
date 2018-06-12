// Import API
using System;
using System.Windows.Forms;
using System.Collections.Generic;

/*
 *      Program:        Memoryscape
 *      File:           frmMemoryscape.cs
 *      Description:    Main form for the game
 *      Author:         Jay Wilson
 *      Class:          CST-117
 *      Date:           May 30, 2018
 */

/// <summary>
/// Namespace Declaration
/// </summary>
namespace Project_2
{
    /// <summary>
    /// Class Declaration
    /// </summary>
    public partial class frmMemoryscape : Form
    {
        /// <summary>
        /// Declare and initialize objects and variables
        /// </summary>
        Sounds sounds = new Sounds();
        static GameManager gameManager = new GameManager();
        public static System.Random random = new System.Random();
        public int ButtonIndex = 0;

        /// <summary>
        /// Main initialization for program
        /// </summary>
        public frmMemoryscape()
        {
            // Initialize everything in the form
            InitializeComponent();

            // Set initial properties for the form not hanlded in InitializeComponent()
            // Note: this can be moved to the initializatiopn() method
            lstSpeed.SelectedIndex = 0;
            cmbColors.SelectedIndex = 0;
        }

        /// <summary>
        /// Button to exit the game.
        /// </summary>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        /// <summary>
        /// Check to see of the the user enabled colorBlind option
        /// </summary>
        private void chkColorBlind_CheckedChanged(object sender, EventArgs e)
        {
            // if enabled...
            if (chkColorBlind.Checked)
            {
                // Enable the selection box
                cmbColors.Enabled = true;
            } else
            {
                // If user disables it, disable the box
                // and reset box selection to NONE
                cmbColors.Enabled = false;
                cmbColors.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Radio button for EASY Difficulty
        /// </summary>
        private void rbEasy_CheckedChanged(object sender, EventArgs e)
        {
            // Set game to Easy
            GameManager.Difficulty = GameManager.difficultySetting.EASY;
        }

        /// <summary>
        /// Radio button for NORMAL Difficulty
        /// </summary>
        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            // Set game to Normal
            GameManager.Difficulty = GameManager.difficultySetting.NORMAL;
        }

        /// <summary>
        /// Radio button for HARD Difficulty
        /// </summary>
        private void rbHard_CheckedChanged(object sender, EventArgs e)
        {
            // Set game to Hard
            GameManager.Difficulty = GameManager.difficultySetting.HARD;
        }

        /// <summary>
        /// Radio button for INSANE Difficulty
        /// </summary>
        private void rbInsane_CheckedChanged(object sender, EventArgs e)
        {
            // Set game to Insane
            GameManager.Difficulty = GameManager.difficultySetting.INSANE;
        }

        /// <summary>
        /// Button to start the game!
        /// </summary>
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            // Start the game.
            StartGame();
            btnStartGame.Enabled = false;
        }

        /// <summary>
        /// Method to initialize and start the game
        /// </summary>
        private void StartGame()
        {
            // Check of there was previously a game over. if so, clean up first.
            if (gameManager.IsGameOver)
            {
                // Clean Up
                gameManager.ResetGame(this);

                // Wipe Game Over status
                gameManager.IsGameOver = false;
            }

            // Initial properties
            pnlDifficulty.Enabled = false;  // Lock Difficulty panel to keep from changing mid game
            lblGameStatus.Visible = false;  // Remove status label if visible
            ButtonIndex = 0;                // Reset the button index

            // Check to see what the current Difficulty is...
            if (GameManager.Difficulty == GameManager.difficultySetting.EASY)
            {
                // Add one new tap to list
                GameManager.TapList.Add(new Tap(1));
            
            } else if (GameManager.Difficulty == GameManager.difficultySetting.NORMAL)
            {
                // Add one new tap to list
                GameManager.TapList.Add(new Tap(1));

                // Make sure the speed doesn't naturally go too low
                if (GameManager.Speed > 500)
                {
                    // If the speed can be reduced, reduce it
                    GameManager.Speed -= 5;
                }

                // Add additional amount to score for user playing on Normal
                GameManager.Score += 5;
            }
            else if (GameManager.Difficulty == GameManager.difficultySetting.HARD)
            {
                // Add two new taps to the game
                GameManager.TapList.AddRange(new List<Tap> { { new Tap(1) }, { new Tap(1) } });

                // Make sure the speed doesn't get too low
                if (GameManager.Speed > 350)
                {
                    // If the speed can be reduce, then reduce it
                    GameManager.Speed -= 10;
                }

                // Add additional score to score for player playing on hard
                GameManager.Score += 10;
            }
            else if (GameManager.Difficulty == GameManager.difficultySetting.INSANE)
            {
                // Add two additional taps to the game
                GameManager.TapList.AddRange(new List<Tap> { { new Tap(1) }, { new Tap(1) } });

                // Make sure the speed doesn't go too low
                if (GameManager.Speed > 250)
                {
                    // If the speed can be reduced, then reduce it
                    GameManager.Speed -= 75;
                }

                // Add additional amount to score for playing on Insane difficulty
                GameManager.Score += 25;
            }

            // Start round
            AnimationTimer timer = new AnimationTimer(this);
        }

        /// <summary>
        /// Handle what happens with player clicks color button
        /// </summary>
        private void btnOne_Click(object sender, EventArgs e)
        {
            CheckChoice(1);
        }

        /// <summary>
        /// Handle what happens with player clicks color button
        /// </summary>
        private void btnTwo_Click(object sender, EventArgs e)
        {
            CheckChoice(2);
        }

        /// <summary>
        /// Handle what happens with player clicks color button
        /// </summary>
        private void btnThree_Click(object sender, EventArgs e)
        {
            CheckChoice(3);
        }

        /// <summary>
        /// Handle what happens with player clicks color button
        /// </summary>
        private void btnFour_Click(object sender, EventArgs e)
        {
            CheckChoice(4);
        }

        /// <summary>
        /// Method that actually handles what happens when user pressed game button
        /// </summary>
        private void CheckChoice(int buttonNumber)
        {
            // check if the next element in the list matches the button chosen
            if (GameManager.TapList[ButtonIndex].ButtonNumber == buttonNumber)
            {
                // It it matches, play sound, add/update score, increase button index
                sounds.PlaySound(buttonNumber);
                GameManager.Score += 10;
                lblScore.Text = GameManager.Score.ToString();
                ++ButtonIndex;

                // If the button index reaches the end, start
                // another round.
                if (ButtonIndex >= GameManager.TapList.Count)
                {
                    // Keep playing!
                    StartGame();
                }
            }
            else
            {
                // If the player chooses poorly...
                // Play failure sound, make status of game visible
                // lock buttons to keep player from clicking them.
                sounds.PlayFail();
                gameManager.IsGameOver = true;
                lblGameStatus.Text = "G A M E\r\nO V E R";
                lblGameStatus.Visible = true;
                ButtonLock(false);
                btnStartGame.Enabled = true;
                pnlDifficulty.Enabled = true;
            }
        }

        /// <summary>
        /// Delegate callback for ButtonLock
        /// </summary>
        /// <param name="status">Bool for button status</param>
        delegate void SetButtonCallback(bool status);

        /// <summary>
        /// Locks or unlocks the colored game buttons
        /// </summary>
        /// <param name="status">Bool for button status</param>
        public void ButtonLock(bool status)
        {
            // Check if invocation required due to threading issues
            if (this.InvokeRequired)
            {
                // Set the callback, and invoke the object
                SetButtonCallback d = new SetButtonCallback(ButtonLock);
                this.Invoke(d, new object[] {status});
            }

            // Update the button status with either true or false
            // to "lock" them.
            btnOne.Enabled = status;
            btnTwo.Enabled = status;
            btnThree.Enabled = status;
            btnFour.Enabled = status;
        }

        /// <summary>
        /// Enable or disable the sound
        /// </summary>
        private void chkAudio_CheckedChanged(object sender, EventArgs e)
        {
            // if the checkbox is enabled...
            if (chkAudio.Checked)
            {
                // Sound is on
                Sounds.Audio = true;
            } else
            {
                // Sound is off
                Sounds.Audio = false;
            }
        }

        /// <summary>
        /// Combobox to allow user to slect color mode for players who may be
        ///     colorblind.
        /// </summary>
        private void cmbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Declare and initialize color object
            Colors colors = new Colors();
            
            // Check which item is selected
            switch (cmbColors.SelectedIndex)
            {
                // If None, use basic color scheme
                case 0:
                    Colors.checkBlindness = Colors.ColorBlindess.NONE;
                    break;
                // If Protanopia, use red-blind schema
                case 1:
                    Colors.checkBlindness = Colors.ColorBlindess.PROTANOPIA;
                    break;
                // If Deuteranopia, use green-blind scema
                case 2:
                    Colors.checkBlindness = Colors.ColorBlindess.DEUTERANOPIA;
                    break;
                // If Tritanopia, ise blue-blind schema
                case 3:
                    Colors.checkBlindness = Colors.ColorBlindess.TRITANOPIA;
                    break;
            }

            // Set the colors in place
            Colors.SetColors();

            // Make sure the base button colors reflect the new color schema
            btnOne.BackColor = Colors.ButtonOneDark;
            btnTwo.BackColor = Colors.ButtonTwoDark;
            btnThree.BackColor = Colors.ButtonThreeDark;
            btnFour.BackColor = Colors.ButtonFourDark;
        }

        /// <summary>
        /// List to determine speed of the game
        /// </summary>
        private void lstSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check the index chosen
            switch (lstSpeed.SelectedIndex)
            {
                // If 0, no speed increase 
                case 0:
                    GameManager.SpeedModification = 0;
                    break;
                // If 1, increase speed by 20ms
                case 1:
                    GameManager.SpeedModification = 20;
                    break;
                // If 2, increase speed by 30ms
                case 2:
                    GameManager.SpeedModification = 30;
                    break;
                // If 3, increase speed by 40ms
                case 3:
                    GameManager.SpeedModification = 40;
                    break;
                // If 4, increase speed by 50ms
                case 4:
                    GameManager.SpeedModification = 50;
                    break;
                // If 5, increase speed by 60ms
                case 5:
                    GameManager.SpeedModification = 60;
                    break;
            }
        }
    }
}
