using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeIMDB
{
    public class Film
    {
        public string FilmAdi { get; set; }
        public double ImdbPuani { get; set; }
        
        public Film(string filmAdi, double imdbPuani)
        {
            FilmAdi = filmAdi;
            ImdbPuani = imdbPuani;
        }
    }
}
