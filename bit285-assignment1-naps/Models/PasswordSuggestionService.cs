using System;
using System.Linq;
namespace bit285assignment1naps.Models
{
    public class PasswordSuggestionService
    {
        private static Random random = new Random();

        public string generatePassword(User user)
        {
            int length = 10;
            string chars = user.LastName + user.BirthYear + user.FavoriteColor;

            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
