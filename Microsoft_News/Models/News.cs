using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_News.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public string Author { get; set; }
        public int CategoryId { get; set; }
        public List<NewsContent> Content { get; set; } = new List<NewsContent>();
        public DateTime CreatedAt { get; } = DateTime.Now;
    }
}
