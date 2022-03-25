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
        Random r = new Random();
        
        public SayaTubeVideo(string title)
        {
            this.title = title;
            playCount = 0;
            id = r.Next(3,5);
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount = this.playCount + playCount;
        }

        public void printVideoDetails()
        {
            Console.WriteLine("ID         : "+ id);
            Console.WriteLine("Title      : "+ title);
            Console.WriteLine("Play Count : "+ playCount);

        }
    }
}
