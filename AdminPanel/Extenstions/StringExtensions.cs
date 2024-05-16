using System;
using System.Collections.Generic;
using System.Linq;

namespace AdminPanel.Extenstions
{

	public static class StringExtensions
	{

		public static string GenerateRandomString(this Random str, int length)
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			return new string(Enumerable.Repeat(chars, length)
				.Select(s => s[str.Next(s.Length)]).ToArray());
		}
        public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> items, Func<T, TKey> property)
        {
            return items.GroupBy(property).Select(x => x.First());
        }
    }
}
