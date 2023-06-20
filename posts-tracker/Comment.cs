using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostTracker
{
    internal class Comment
    {
        public string content { get; set; }

        public Comment() { }

        public Comment (string content)
        {
            this.content = content;
        }
    }
}
