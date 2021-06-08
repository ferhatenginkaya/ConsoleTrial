using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AnimalsGame.Models
{
    public class Arazi
    {
        public Arazi()
        {
            En = 500;
            Boy = 500;
            Hayvanlar = new List<Hayvan>();
        }
        public int En { get; set; }
        public int Boy { get; set; }

        public List<Hayvan> Hayvanlar;
    }
}
