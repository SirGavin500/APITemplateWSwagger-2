using System;

namespace APITemplateWSwagger.Services
{
    public class GuessItService
    {
        private readonly Random random = new();

        public int GenerateNumber(int max)
        {
            return random.Next(1, max + 1);
        }

        public string Compare(int guess, int number)
        {
            if (guess == number) return "Correct";
            if (guess < number) return "Higher";
            return "Lower";
        }
    }
}
