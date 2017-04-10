using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
   public class Movie
    {
        private string title;
        private string genre;
        public Movie (string title, string genre)
        {
            this.title = title;
            this.genre = genre;
        }
        public string GetTitle()
        {
            return title;
        }
        public string GetGenre()
        {
            return genre;
        }
    }
}
