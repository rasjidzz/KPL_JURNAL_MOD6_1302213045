using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JURNAL_MOD6_MRISJADS_1302213045
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playcount;
        public SayaTubeVideo(string judul)
        {
            Contract.Requires(judul.Length < 100);
            Contract.Requires(judul != null);
            this.title = judul;
            Random rand = new Random();
            int idrand = rand.Next(00000, 99999);
            this.id = idrand;
            this.playcount = 0;
        }
        public void Increaseplaycount(int count)
        {
            Debug.Assert(count <= 25000000);
            Debug.Assert(count >= 0);
            this.playcount += count;
            try
            {
                checked
                {
                    this.playcount += count;
                }
            }
            catch(OverflowException)
            {
                Console.WriteLine("Count Play Maximum");
            }
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Film : " + this.id);
            Console.WriteLine("Judul Film : " + this.title);
            Console.WriteLine("Play Count Film : " + this.playcount);
        }
        public int getplaycount()
        {
            return this.playcount;
        }
        public string gettitle()
        {
            return this.title;
        }
    }
}
