using System.Drawing;

/// <summary>
/// Namespace Declaration
/// </summary>
namespace Project_2
{
    /// <summary>
    /// Class Declaration
    /// </summary>
    class Colors
    {
        /// <summary>
        /// Properties for each button state.
        ///     Light is for active
        ///     Dark is for inactive
        /// </summary>
        public static Color ButtonOneLight { get; set; }
        public static Color ButtonOneDark { get; set; }
        public static Color ButtonTwoLight { get; set; }
        public static Color ButtonTwoDark { get; set; }
        public static Color ButtonThreeLight { get; set; }
        public static Color ButtonThreeDark { get; set; }
        public static Color ButtonFourLight { get; set; }
        public static Color ButtonFourDark { get; set; }

        /// <summary>
        /// Enum to determine color state
        /// </summary>
        public enum ColorBlindess
        {
            NONE,
            PROTANOPIA,
            DEUTERANOPIA,
            TRITANOPIA
        }

        /// <summary>
        /// verifies the color state
        /// </summary>
        public static ColorBlindess checkBlindness { get; set; } = ColorBlindess.NONE;

        /// <summary>
        /// Set the colors according to the colorBlindness state
        /// </summary>
        public static void SetColors()
        {
            // Define what color to use for light/dark per each button
            switch (checkBlindness)
            {
                // For normal vision
                case ColorBlindess.NONE:
                    ButtonOneDark = Color.DarkSeaGreen;
                    ButtonOneLight = Color.PaleGreen;

                    ButtonTwoDark = Color.IndianRed;
                    ButtonTwoLight = Color.LightCoral;

                    ButtonThreeDark = Color.PaleGoldenrod;
                    ButtonThreeLight = Color.LightYellow;

                    ButtonFourDark = Color.LightSteelBlue;
                    ButtonFourLight = Color.AliceBlue;
                    break;
                // For those red-blind
                case ColorBlindess.PROTANOPIA:
                    ButtonOneDark = Color.Purple;
                    ButtonOneLight = Color.Violet;

                    ButtonTwoDark = Color.DarkOrange;
                    ButtonTwoLight = Color.Orange;

                    ButtonThreeDark = Color.Yellow;
                    ButtonThreeLight = Color.LightYellow;

                    ButtonFourDark = Color.Green;
                    ButtonFourLight = Color.GreenYellow;
                    break;
                // For those Green-Blind
                case ColorBlindess.DEUTERANOPIA:
                    ButtonOneDark = Color.Green;
                    ButtonOneLight = Color.GreenYellow;

                    ButtonTwoDark = Color.Yellow;
                    ButtonTwoLight = Color.LightYellow;

                    ButtonThreeDark = Color.DarkOrange;
                    ButtonThreeLight = Color.Orange;

                    ButtonFourDark = Color.Purple;
                    ButtonFourLight = Color.Violet;
                    break;
                // For those Blue-blind
                case ColorBlindess.TRITANOPIA:
                    ButtonOneDark = Color.Purple;
                    ButtonOneLight = Color.Violet;

                    ButtonTwoDark = Color.DeepPink;
                    ButtonTwoLight = Color.HotPink;

                    ButtonThreeDark = Color.ForestGreen;
                    ButtonThreeLight = Color.GreenYellow;

                    ButtonFourDark = Color.DarkOrange;
                    ButtonFourLight = Color.Orange;
                    break;
            }
        }
    }
}
