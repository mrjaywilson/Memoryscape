// Import API
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

/// <summary>
/// Namespace Declaration
/// </summary>
namespace Project_2
{
    /// <summary>
    /// Class Declaration
    /// </summary>
    class AnimationTimer
    {
        /// <summary>
        /// Object and variable declarations and initializations
        /// </summary>
        int index;
        frmMemoryscape game;
        Colors colors = new Colors();
        private System.Timers.Timer _timer;
        private Sounds sounds = new Sounds();

        public AnimationTimer(frmMemoryscape gameRef)
        {
            // Store reference of main game in 'game'
            game = gameRef;

            // lock the buttons while animating AI
            game.ButtonLock(false);

            // Start animation
            Start();
        }

        /// <summary>
        /// Method to start animation
        /// </summary>
        public void Start()
        {
            // Set index to zero for fresh start
            index = 0;

            // Set the speed multiplier
            GameManager.SetMultiplier();

            // Initialize timer, set up event handling, and enable the timer
            _timer = new System.Timers.Timer(GameManager.Speed - (GameManager.SpeedModification * GameManager.Multiplier)); // One second minus modification
            _timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
            _timer.Enabled = true;
        }

        /// <summary>
        /// What happens as each timer count elapses
        /// </summary>
        public void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Variable to hold sleep length
            int sleepValue;

            // If the speed is greater than 300, leave it alone
            if (GameManager.Speed > 300)
            {
                sleepValue = 300;
            } else // otherwise...
            {
                // Set the sleep value to ensure sleep doesn't interfere with
                // the animation, sound, and playability
                sleepValue = (GameManager.Speed / 2);
            }

            // Display the pattern for the user to watch and learn.
            // This changes the color of the buttons according to the color scheme,
            //      plays a sound, waits for the sleep value to elapse,
            //      and returns the button back to the correct origin color
            switch (GameManager.TapList[index].ButtonNumber)
            {
                case 1:
                    sounds.PlaySound(1);
                    game.btnOne.BackColor = Colors.ButtonOneLight;
                    System.Threading.Thread.Sleep(sleepValue);
                    game.btnOne.BackColor = Colors.ButtonOneDark;
                    break;
                case 2:
                    sounds.PlaySound(2);
                    game.btnTwo.BackColor = Colors.ButtonTwoLight;
                    System.Threading.Thread.Sleep(sleepValue);
                    game.btnTwo.BackColor = Colors.ButtonTwoDark;
                    break;
                case 3:
                    sounds.PlaySound(3);
                    game.btnThree.BackColor = Colors.ButtonThreeLight;
                    System.Threading.Thread.Sleep(sleepValue);
                    game.btnThree.BackColor = Colors.ButtonThreeDark;
                    break;
                case 4:
                    sounds.PlaySound(4);
                    game.btnFour.BackColor = Colors.ButtonFourLight;
                    System.Threading.Thread.Sleep(sleepValue);
                    game.btnFour.BackColor = Colors.ButtonFourDark;
                    break;
            }
            // Advance the index
            ++index;

            // Check if the index has gone beyond the scope of the list
            // If so...
            if (index >= GameManager.TapList.Count)
            {
                // Disable the timer
                _timer.Enabled = false;

                // Unlock the buttons
                game.ButtonLock(true);

            }
        }
    }
}