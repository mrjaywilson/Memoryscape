// Import API
using System.Collections.Generic;

/// <summary>
/// Namespace Declaration
/// </summary>
namespace Project_2
{
    /// <summary>
    /// Class Declaration
    /// </summary>
    public class GameManager
    {
        /// <summary>
        /// Enum to access for setting the difficulty
        /// </summary>
        public enum difficultySetting
        {
            EASY,       // +1 guess increase per turn, No Speed increase
            NORMAL,     // +1 guess increase per turn, +10 Speed increase
            HARD,       // +2 guess increase per turn, +10 speed increase
            INSANE      // +2 guess increase per turn, +25 speed increase
        }

        /// <summary>
        /// Setup List for tapping lights
        /// </summary>
        public static List<Tap> TapList = new List<Tap>();

        /// <summary>
        /// Property for setting the difficulty of the game
        /// </summary>
        public static difficultySetting Difficulty { get; set; }

        /// <summary>
        /// Property for keeping score
        /// </summary>
        public static int Score { get; set; } = 0;

        // Proerty for setting the game speed
        /// <summary>
        /// Properties for adjusting speed of game
        ///     Speed
        ///         Sets the general speed of the game per turn
        ///     SpeedModification
        ///         Modifies the Speed based on Difficulty Setting
        ///     Multiplier
        ///         Modifies SpeedModification based on Game Speed user choice
        ///     IsGameOver
        ///         Reports of the game has ended
        /// </summary>
        public static int Speed { get; set; } = 1000;
        public static int SpeedModification { get; set; } = 0;
        public static int Multiplier { get; set; } = 1;
        public bool IsGameOver { get; set; } = false;

        /// <summary>
        /// Sets the speed multiplier
        /// </summary>
        public static void SetMultiplier()
        {
            // Make change based on the difficulty
            // NOTE: Insane already gets insanely fase, so no
            //       modification will be made.
            if (Difficulty == difficultySetting.EASY)
            {
                Multiplier = 10;
            } else if (Difficulty == difficultySetting.NORMAL)
            {
                Multiplier = 3;
            } else if (Difficulty == difficultySetting.HARD)
            {
                Multiplier = 2;
            } else if (Difficulty == difficultySetting.INSANE)
            {
                Multiplier = 1;
            }
        }

        /// <summary>
        /// Resets the game
        /// </summary>
        public void ResetGame(frmMemoryscape game)
        {
            // Reset various properties and lists on Game Over
            Tap.TotalTapsAvailable = 0;
            IsGameOver = false;
            TapList.Clear();
            Score = 0;

            game.pnlDifficulty.Enabled = true;
            game.lblScore.Text = "0";
            game.ButtonLock(false);
            game.ButtonIndex = 0;
        }
    }
}
