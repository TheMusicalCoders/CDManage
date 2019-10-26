using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDClasses
{
    class CDClasses
    {
        private string album;
        private string date;
        private string id;
        private string artist;
        private string genre;
        private string songName;
        private int songNum;

        public void setAlbum(string album)
        {
            this.album = album;
        }

        public void setDate(string date)
        {
            this.date = date;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public void setArtist(string artist)
        {
            this.artist = artist;
        }

        public void setGenre(string genre)
        {
            this.genre = genre;
        }

        public void setSongNum(int songNum)
        {
            this.songNum = songNum;
        }

        public void setSongName(string songName)
        {
            this.songName = songName;
        }

        public string getAlbum()
        {
            return album;
        }

        public string getDate()
        {
            return date;
        }

        public string getID()
        {
            return id;
        }

        public string getArtist()
        {
            return artist;
        }

        public string getGenre()
        {
            return genre;
        }

        public int getSongNum()
        {
            return songNum;
        }

        public string getSongName()
        {
            return songName;
        }

        

        [STAThread]
        static void Main()
        {
           /* Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); */
        }
    }
}
