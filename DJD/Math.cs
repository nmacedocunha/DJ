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
        /// Check which value is the highest.
        /// </summary>
        /// <returns>Returns the max value</returns>
        public static int Max(int[] values)
        {
            int value = values.Length > 0 ? values[0] : 0;

            for (int i = 0; i < values.Length; i++)
            {
                value = values[i] > value ? values[i] : value;
            }

            return value;
        }

        /// <summary>
        /// Check which value is the highest.
        /// </summary>
        /// <returns>Returns the max value</returns>
        public static float Max(float[] values)
        {
            float value = values.Length > 0 ? values[0] : 0;

            for (int i = 0; i < values.Length; i++)
            {
                value = Max(value, values[i]);
            }

            return value;
        }

        /// <summary>
        /// Average of the values.
        /// </summary>
        /// <returns>The average.</returns>
        public static int Average(int[] values)
        {
            return Sum(values) / values.Length;
        }

        /// <summary>
        /// Average of the values.
        /// </summary>
        /// <returns>The average.</returns>
        public static float Average(float[] values)
        {
            return Sum(values) / values.Length;
        }

        /// <summary>
        /// Clamp the specified value between a Min and Max.
        /// </summary>
        /// <returns>Returns the value within restrictions.</returns>
        public static int Clamp(int value, int min, int max)
        {

            return value > max ? max : value < min ? min : value;
        }

        /// <summary>
        /// Clamp the specified value between a Min and Max.
        /// </summary>
        /// <returns>Returns the value within restrictions.</returns>
        public static float Clamp(float value, float min, float max)
        {
            return value > max ? max : value < min ? min : value;
        }

        /// <summary>
        /// Sum of collection of numbers
        /// </summary>
        /// <returns>The sum value.</returns>
        public static int Sum(int[] values)
        {
            int value = 0;

            for (int i = 0; i < values.Length; i++)
            {
                value += values[i];
            }

            return value;
        }

        /// <summary>
        /// Sum of collection of numbers
        /// </summary>
        /// <returns>The sum value.</returns>
        public static float Sum(float[] values)
        {
            float value = 0;

            for (int i = 0; i < values.Length; i++)
            {
                value += values[i];
            }

            return value;
        }

        /// <summary>
        /// The Square value of a number
        /// </summary>
        /// <returns>The square of the value</returns>
        public static int Square(int value)
        {
            return value * value;
        }

        /// <summary>
        /// The Square value of a number
        /// </summary>
        /// <returns>The square of the value</returns>
        public static float Square(float value)
        {
            return value * value;
        }


        /// <summary>
        /// The power of a certain number. Number^X 
        /// </summary>
        /// <returns>The power of the value</returns>
        public static int Power(int value, int times)
        {
            for (int i = 0; i < times; i++)
            {
                value *= value;
            }

            return value;
        }

        /// <summary>
        /// The power of a certain number. Number^X 
        /// </summary>
        /// <returns>The power of the value</returns>
        public static float Power(float value, float times)
        {
            for (int i = 0; i < times; i++)
            {
                value *= value;
            }

            return value;
        }
        /// <summary>
        /// Check if the number is prime or not
        /// </summary>
        public static bool Prime(int value)
        {
            int count = 0;

            for (int i = 0; i < value; i++)
            {
                if (i % value == 0)
                    count++;
            }

            return !(count > 2);
        }

        /// <summary>
        /// Check if value is even.
        /// </summary>
        /// <returns><c>true</c>, if number was evened, <c>false</c> if number is odd</returns>
        public static bool EvenNumber(int value)
        {
            return value % 2 == 0;
        }

        // Add square root function
    }
}
