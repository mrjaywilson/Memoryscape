
/// <summary>
/// Namespace Declaration
/// </summary>
namespace Project_2
{
    /// <summary>
    /// Class Declaration
    /// </summary>
    public class Tap
    {
        /// <summary>
        /// Declare (some initialized) objects and variables
        /// </summary>
        private int _buttonNumber;
        public static int TotalTapsAvailable;

        public int ButtonNumber => _buttonNumber;

        /// <summary>
        /// Creates a tap object with 1 tap and the given button number
        /// </summary>
        /// <param name="tapNumber">Determines the button affected</param>
        public Tap(int tapNumber)
        {
            TotalTapsAvailable += tapNumber;
            this._buttonNumber = getButtonNumber();
        }

        /// <summary>
        /// Provides a random number for the button
        /// </summary>
        /// <returns></returns>
        private int getButtonNumber()
        {
            // Returns a random number between 1 (inclusive) and 4 (inclusive).
            return frmMemoryscape.random.Next(1, 5);
        }
    }
}
