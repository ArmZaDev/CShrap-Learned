using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funny1
{
    internal class Movie
    {
        public string title;
        public string director;
        public string rating;

        public Movie(string atitle, string adirector, string arating)
        {
            title = atitle;
            director = adirector;
            rating = arating;
        }
    }
}
