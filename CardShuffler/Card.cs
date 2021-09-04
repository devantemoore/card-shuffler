using System;
namespace CardShuffler
{
    public class Card
    { 
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
