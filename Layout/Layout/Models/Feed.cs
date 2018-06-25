using System.Collections.Generic;

namespace Layout.Models
{
    public class Feed
    {
        public string Users { get; set; }
        public string Audience { get; set; }
        public string PostTime { get; set; }
        public string PostBody { get; set; }
        public string LikesCount { get; set; }
        public string SharedsCount { get; set; }
        public string PostCount { get; set; }

        public bool IsCoolLike { get; set; }
        public bool IsHeart { get; set; }
        public bool IsKkkLike { get; set; }
        public bool IsOhLike { get; set; }
        public bool IsCryLike { get; set; }
        public bool IsAngryLike { get; set; }
    }
}
