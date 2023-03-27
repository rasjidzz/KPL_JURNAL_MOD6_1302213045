using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JURNAL_MOD6_MRISJADS_1302213045
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> Uploadedvideos;
        public String username;

        public SayaTubeUser(String nama)
        {
            this.username = nama;
            this.Uploadedvideos = new List<SayaTubeVideo>();
            Random rand = new Random();
            int idrand = rand.Next(00000, 99999);
            this.id = idrand;
        }
        public void addvideo(SayaTubeVideo videobaru)
        {
            Uploadedvideos.Add(videobaru);
        }
        public int getTotalVideoCount()
        {
            int total = 0;
            for (int i = 0; i < Uploadedvideos.Count; i++)
            {
                total += Uploadedvideos[i].getplaycount();
            }
            return total;
        }
        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User : " + this.username);
            for (int i = 0; i < Uploadedvideos.Count; i++)
            {
                Console.WriteLine("Video ke " + (i + 1) +" "+ Uploadedvideos[i].gettitle());
            }
        }
    }
}
