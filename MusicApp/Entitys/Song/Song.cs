using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Storage;
using Windows.Storage.FileProperties;
using System.Linq;

namespace MusicApp.Entitys
{
    public class Song
    {
        #region Properties
        public int ID { get; set; }
        public string FullDir { get; set; }
        public string NameFile { get; set; }
        public string SongTitle { get; set; }
        public string SongSubTitle { get; set; }
        public string SongArtist { get; set; }
        public string AlbumTitle { get; set; }
        //public string AlbumArtist { get; set; }
        private readonly List<string> composers = new List<string>();
        public List<string> Composers { get => composers; }
        private readonly List<string> genre = new List<string>();
        public List<string> Genre { get => genre; }
        //public uint Rating { get; set; }
        public uint Year { get; set; }
        public string Duration { get; set; } 
        #endregion
        public bool GetInfo()
        {
            if (FullDir == null)
                return false;
            IAsyncOperation<StorageFile> file = StorageFile.GetFileFromPathAsync(path: FullDir);
            while(file.Status != AsyncStatus.Completed) { }
            StorageFile f = file.GetResults();

            if (f != null)
            {
                // Get music properties
                IAsyncOperation<MusicProperties> musicProperties = f.Properties.GetMusicPropertiesAsync();
                while (musicProperties.Status != AsyncStatus.Completed) { }
                MusicProperties m = musicProperties.GetResults();
                AlbumTitle = m.Album.Trim();
                //AlbumArtist = m.AlbumArtist.Trim();
                SongArtist = m.Artist.Trim();
                Genre.Clear();
                foreach (string i in m.Genre)
                    Genre.Add(i);
                Composers.Clear();
                Composers.AddRange(from string val in m.Composers
                                   select val.Trim());
                //Rating = m.Rating;
                SongSubTitle = m.Subtitle.Trim();
                SongTitle = m.Title.Trim();
                Year = m.Year;
                NameFile = f.Name;
                Duration = m.Duration.ToString(@"mm\:ss");
                if (SongTitle == "")
                {
                    var t = NameFile.Split('.').ToList();
                    t.RemoveAt(t.Count - 1);
                    SongTitle = string.Join("", t.ToArray());
                }
                if (SongArtist == "")
                    SongArtist = "Unknown Artist";
                if (AlbumTitle == "")
                    SongArtist = "Unknown Album";
            }
            return true;
        }
        public bool SaveInfo()
        {
            if (FullDir == null)
                return false;
            IAsyncOperation<StorageFile> file = StorageFile.GetFileFromPathAsync(path: FullDir);
            while (file.Status != AsyncStatus.Completed) { }
            StorageFile f = file.GetResults();

            if (f != null)
            {
                // Get music properties
                IAsyncOperation<MusicProperties> musicProperties = f.Properties.GetMusicPropertiesAsync();
                while (musicProperties.Status != AsyncStatus.Completed) { }
                MusicProperties m = musicProperties.GetResults();
                m.Album = AlbumTitle;
                //m.AlbumArtist = AlbumArtist;
                m.Artist = SongArtist;
                m.Genre.Clear();
                foreach (string val in Genre)
                    m.Genre.Add(val);
                m.Composers.Clear();
                foreach (string val in Composers)
                    m.Composers.Add(val);
                //m.Rating = Rating;
                m.Subtitle = SongSubTitle;
                m.Title = SongTitle;
                m.Year = Year;
                IAsyncAction t = m.SavePropertiesAsync();
                
                while (t.Status != AsyncStatus.Completed) { }
                //Console.WriteLine(t.GetResults());
            }
            return true;
        }
    }
}
