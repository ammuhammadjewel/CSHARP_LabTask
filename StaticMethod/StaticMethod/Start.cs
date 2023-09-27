using System;
using System.Security.Cryptography;

namespace StaticMethod
{
    class Start
    {
        static void Main(string[] args)
        {
            Song song = new Song("ehd e wafa", "Unkown",4);
            //Console.WriteLine("Song count number: " + Song.songCount);
            //Song song2 = new Song("isqla", "kown", 5);
            Song song3 = new Song("razz ulfat", "kk", 5);
            /*{
                title = "razz ulfat",
                artist = "Unkown",
                duration = 50
            };*/
            //Console.WriteLine(song.title);
            //cConsole.WriteLine(song2.artist);


            Console.WriteLine("Song count number: " +Song.songCount);

            Console.ReadLine();
        }
    }
}