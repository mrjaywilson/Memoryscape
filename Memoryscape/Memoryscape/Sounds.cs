// Import API
using System.IO;
using System.Media;

/// <summary>
/// Namespace Declaration
/// </summary>
namespace Project_2
{
    /// <summary>
    /// Class Declaration
    /// </summary>
    class Sounds
    {

        /// <summary>
        /// Declaration of variables and objects
        /// </summary>
        private SoundPlayer soundOne, soundTwo, soundThree, soundFour, fail;
        string soundPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\sounds\";

        /// <summary>
        /// Property for Audio Toggle
        /// </summary>
        public static bool Audio { get; set; } = true;

        /// <summary>
        /// Initializes Sounds
        /// </summary>
        public Sounds()
        {
            soundOne = new SoundPlayer(soundPath + "btnOne.wav");
            soundTwo = new SoundPlayer(soundPath + "btnTwo.wav");
            soundThree = new SoundPlayer(soundPath + "btnThree.wav");
            soundFour = new SoundPlayer(soundPath + "btnFour.wav");
            fail = new SoundPlayer(soundPath + "fail.wav");
        }

        /// <summary>
        /// Play sounds based on the given button number
        /// </summary>
        /// <param name="ButtonNumber">Button number of indicated button</param>
        public void PlaySound(int ButtonNumber)
        {
            // If sound is on...
            if (Audio)
            {
                // Play the sounds based on the button pressed
                switch (ButtonNumber)
                {
                    case 1:
                        soundOne.Play();
                        break;
                    case 2:
                        soundTwo.Play();
                        break;
                    case 3:
                        soundThree.Play();
                        break;
                    case 4:
                        soundFour.Play();
                        break;
                }
            }
        }

        /// <summary>
        /// Play failure sound of player guesses wrong pattern
        /// </summary>
        public void PlayFail()
        {
            // If audio is turned on...
            if (Audio)
            {
                // Play sound
                fail.Play();
            }
        }
    }
}
