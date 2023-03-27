using System;
using System.Collections.Generic;
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
            this.title = judul;
            Random rand = new Random();
            int idrand = rand.Next(00000, 99999);
            this.id = idrand;
            this.playcount = 0;
        }
        public void Increaseplaycount(int count)
        {
            this.playcount += count;
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
