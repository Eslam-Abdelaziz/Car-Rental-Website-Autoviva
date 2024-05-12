using System;
using System.Linq;

namespace CarRental.Application.Extenstions
{

	public static class StringExtensions
	{

		public static string GenerateRandomString(this Random str, int length)
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			return new string(Enumerable.Repeat(chars, length)
				.Select(s => s[str.Next(s.Length)]).ToArray());
		}
        public static string FirstCharToUpper(this string input) =>
       input switch
       {
           null => throw new ArgumentNullException(nameof(input)),
           "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
           _ => string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1))
       };
    }
}
