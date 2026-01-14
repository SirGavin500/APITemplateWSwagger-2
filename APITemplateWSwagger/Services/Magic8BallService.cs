using System;
using System.Collections.Generic;

namespace APITemplateWSwagger.Services
{
    public class Magic8BallService
    {
        private readonly List<string> responses = new()
        {
            "Yes",
            "No",
            "Maybe",
            "Ask again later",
            "Definitely",
            "Absolutely not",
            "I don't think so",
            "It is certain"
        };

        private readonly Random random = new();

        public string GetResponse()
        {
            return responses[random.Next(responses.Count)];
        }
    }
}
