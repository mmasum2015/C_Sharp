using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusLib
{
    public class Cirkus
    {
        private string name;
        private Dictionary<Artist, int> ArtistFörställningarDictionary = new Dictionary<Artist, int>();

        public Cirkus(string name)
        {
            this.name = name;
        }

        public void Anställ(Artist artist)
        {

            ArtistFörställningarDictionary.Add(artist, 0);
        }

        public void ArtistUppträdande(Artist artist)
        {
            ArtistFörställningarDictionary[artist]++;
        }
        public override string ToString()
        {
            var message= $"Cirkus {this.name} har {this.AntalArtister} artister.";
            //foreach (var artistFörställningarEntry in ArtistFörställningarDictionary)
            //{
            //    string gånger = "gång";
            //    if (artistFörställningarEntry.Value > 1)
            //        gånger += "er";
            //    message += $"{artistFörställningarEntry.Key.name} har uppträtt {artistFörställningarEntry}";
            //}
            //Debug.WriteLine(message);
            return message;
        }
       public int AntalArtister
        {
            get
            {
                return this.ArtistFörställningarDictionary.Count;
            }
        }
    }


}
