using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul5_1302201138
{
    internal class SayaTubeVideo
    {
        int id, playCount;
        string title;
        
        public SayaTubeVideo(string title)
        {
            playCount = 0;
            try
            {
                if (title.Length > 100) throw new Exception("Panjang title melewati batas!");
                this.title = title;
                Random r = new Random();
                id = r.Next(1, 6);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                this.title = "-";
            }
        }

        public void IncreasePlayCount(int playCount)
        {
            try
            {
                int c = checked(playCount + 2137483647);
                this.playCount = this.playCount + playCount;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void printVideoDetails()
        {
            Console.WriteLine("        ID : "+ id);
            Console.WriteLine("     Title : "+ title);
            Console.WriteLine("Play Count : "+ playCount);

        }
    }
}
