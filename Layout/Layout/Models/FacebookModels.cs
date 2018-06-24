using System.Collections.Generic;

namespace Layout.Models
{
    public class FacebookModels
    {
        public IEnumerable<string> Users { get; set; }
        public string PostTime { get; set; }
        public string PostBody { get; set; }
        public int LikesCount { get; set; }
        public int SharedsCount { get; set; }
    }
}
