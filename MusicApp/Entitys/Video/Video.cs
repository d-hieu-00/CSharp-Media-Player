using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Storage;
using Windows.Storage.FileProperties;

namespace MusicApp.Entitys.Video
{
    public class Video
    {
        #region Properties
        public int ID { get; set; }
        public string FullDir { get; set; }
        public string NameFile { get; set; }
        public string VideoTitle { get; set; }
        public string VideoSubTitle { get; set; }
        public string Publisher { get; set; }
        private readonly List<string> directors = new List<string>();
        public List<string> Directors { get => directors; }
        private readonly List<string> producers = new List<string>();
        public List<string> Producers { get => producers; }
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
            while (file.Status != AsyncStatus.Completed) { }
            StorageFile f = file.GetResults();
            if (f != null)
            {
                // Get video properties
                IAsyncOperation<VideoProperties> videosProperties = f.Properties.GetVideoPropertiesAsync();
                while (videosProperties.Status != AsyncStatus.Completed) { }
                VideoProperties v = videosProperties.GetResults();
                Directors.Clear();
                Directors.AddRange(from string val in v.Directors
                                   select val.Trim());
                Genre.Clear();
                Genre.AddRange(from string val in v.Keywords
                               select val.Trim());
                Producers.Clear();
                Producers.AddRange(from string val in v.Producers
                                   select val.Trim());
                Publisher = v.Publisher.Trim();
                //Rating = v.Rating;
                VideoSubTitle = v.Subtitle.Trim();
                VideoTitle = v.Title.Trim();                
                Year = v.Year;
                NameFile = f.Name;
                Duration = v.Duration.ToString(@"mm\:ss");
                if (VideoTitle == "")
                {
                    var t = NameFile.Split('.').ToList();
                    t.RemoveAt(t.Count - 1);
                    VideoTitle = string.Join("", t.ToArray());
                }
            }
            Publisher.ToString();
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
                // Set video properties
                IAsyncOperation<VideoProperties> videosProperties = f.Properties.GetVideoPropertiesAsync();
                while (videosProperties.Status != AsyncStatus.Completed) { }
                VideoProperties v = videosProperties.GetResults();
                v.Directors.Clear();
                foreach (string val in Directors)
                    v.Directors.Add(val);
                v.Keywords.Clear();
                foreach (string val in Genre)
                    v.Keywords.Add(val);
                v.Producers.Clear();
                foreach (string val in Producers)
                    v.Producers.Add(val);
                v.Publisher = Publisher;
                //v.Rating = Rating;
                v.Subtitle = VideoSubTitle;
                v.Title = VideoTitle;
                v.Year = Year;
                IAsyncAction t = v.SavePropertiesAsync();
                while (t.Status != AsyncStatus.Completed) { }
            }
            return true;
        }
    }
}
