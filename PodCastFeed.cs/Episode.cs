using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodCastFeed.cs
{
    public class Episode
    {
        public String Title { get; set; }
        public String Authors { get; set; }
        public DateTime PubDate { get; set; }
        public Uri FileUrl { get; set; }
        public long Lenght { get; set; }
        public String Type { get; set; }
        public Uri ImageURL { get; set; }
        public String Description { get; set; }

        public Episode()
        {
            
        }

        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2}\n\n{3}", this.Title, this.Authors, this.PubDate.ToString(),
                this.Description);
        }

    }
}
