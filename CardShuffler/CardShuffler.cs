using System;
using System.Collections.Generic;

namespace CardShuffler
{
    public static class CardShuffler<T> where T : class
    {
        public static IList<T> Shuffle(IList<T> input) 
        {
            // split deck
            var length = input.Count;
            var middle = length / 2;
            var left = 0;
            var right = middle;
            var cardTotal = 0;
            var output = new List<T>();
            var random = new Random();

            while (cardTotal < 52)
            {
                // add cards from left
                var randomShuffle = random.Next(1,4);
                for (int i = 0; i < randomShuffle; i++)
                {
                    if (left == middle) continue;
                    output.Add(input[left]);
                    left++;
                    cardTotal++;
                }
                randomShuffle = random.Next(1, 4);
                for (int j = 0; j < randomShuffle; j++)
                {
                    if (right == length) break;
                    output.Add(input[right]);
                    right++;
                    cardTotal++;
                }
                if (right == length) break;

            }
            return output;
        }
    }
}
