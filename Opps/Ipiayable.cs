using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    internal interface Ipiayable
    {
        void Play();

    }
    class VideoPlayer:Ipiayable
    {
        public void Play()
        {
            Console.WriteLine("Playing video....!");
        }
    }
    class MusicPlayer:Ipiayable
    {
        public void Play()
        {
            Console.WriteLine("Playing Music.....!");
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            VideoPlayer obj1 = new VideoPlayer();
            MusicPlayer obj2 = new MusicPlayer();

            obj1.Play();
            obj2.Play();

        }
    }
}
