using System;

namespace DJD
{
    public static class Math
    {
        public static int Abs(int value)
        {
            return value > 0 ? value : value * -1;
        }

        public static float Abs(float value)
        {
            return value > 0 ? value : value * -1;
        }

        public static int Max(int valueA, int valueB)
        {
            return valueA > valueB ? valueA : valueB;
        }

        public static float Max(float valueA, float valueB)
        {
            return valueA > valueB ? valueA : valueB;
        }
    }
}
