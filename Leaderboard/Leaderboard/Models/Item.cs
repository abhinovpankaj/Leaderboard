using System;

namespace Leaderboard.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public int Sequence { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }

        public string ImageSource { get; set; }
        public bool IsIncreasing { get; set; }
    }
}