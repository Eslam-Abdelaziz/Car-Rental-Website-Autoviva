using System.Security.Cryptography;
namespace CarRental.Application.Helpers
{

    public static class RandomHelper
    {
        public static uint GenerateConfirmationCode(int digits)
        {
            if (digits < 1 || digits > 9)
            {
                throw new ArgumentException("The number of digits must be between 1 and 9.");
            }
            int min = (int)Math.Pow(10, digits - 1);
            int max = (int)Math.Pow(10, digits) - 1;
            byte[] randomBytes = new byte[4];
            RandomNumberGenerator.Fill(randomBytes);
            uint randomNumber = BitConverter.ToUInt32(randomBytes, 0);
            double randomDouble = (randomNumber / (double)Int32.MaxValue) * (max - min) + min;
            uint randomInt = (uint)Math.Floor(randomDouble);
            return randomInt;
        }

    }
}
