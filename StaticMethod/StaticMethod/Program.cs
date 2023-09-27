using System;
namespace StaticMethod
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount;
        public Song(string tTitle, string aArtist, int dDuration)
        {
            title = tTitle;
            artist = aArtist;
            duration = dDuration;
            songCount++;
        }
        public Song()
        {

        }
    }
}