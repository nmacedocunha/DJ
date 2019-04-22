namespace DJD
{
    public static class Math
    {
        /// <summary>
        /// Absolute value of value.
        /// </summary>
        /// <returns>Returns the integer value.</returns>
        public static int Abs(int value)
        {
            return value > 0 ? value : value * -1;
        }

        /// <summary>
        /// Absolute value of value.
        /// </summary>
        /// <returns>Returns the float value.</returns>
        public static float Abs(float value)
        {
            return value > 0 ? value : value * -1;
        }

        /// <summary>
        /// Check which value is the highest.
        /// </summary>
        /// <returns>Returns the max value</returns>
        public static int Max(int valueA, int valueB)
        {
            return valueA > valueB ? valueA : valueB;
        }

        /// <summary>
        /// Check which value is the highest.
        /// </summary>
        /// <returns>Returns the max value</returns>
        public static float Max(float valueA, float valueB)
        {
            return valueA > valueB ? valueA : valueB;
        }

        /// <summary>
        /// Check which value is the hight
        /// </summary>
        /// <returns>Returns the max value</returns>
        public static int Max(int[] values)
        {
            int value = values.Length > 0 ? values[0] : 0;

            for (int i = 0; i < values.Length; i++)
            {
                value = value > values[i] ? values[i] : value;
            }

            return value;
        }

        /// <summary>
        /// Check which value is the hight
        /// </summary>
        /// <returns>Returns the max value</returns>
        public static float Max(float[] values)
        {
            float value = values.Length > 0 ? values[0] : 0;

            for (int i = 0; i < values.Length; i++)
            {
                value = value > values[i] ? values[i] : value;
            }

            return value;
        }
    }
}
