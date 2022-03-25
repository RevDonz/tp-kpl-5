using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302204051
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random rnd = new Random();
            this.id = rnd.Next(0, 100000);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int data)
        {
            this.playCount += data;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine(this.id);
            Console.WriteLine(this.title);
            Console.WriteLine(this.playCount);
        }
    }
}
