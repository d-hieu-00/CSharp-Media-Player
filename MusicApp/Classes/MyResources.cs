using MusicApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp.Classes
{
    public class MyResources
    {
        private static MainForm main;
        private static MyData resources;
        public static MainForm Main { get => main; }
        public static MyData Resources { get => resources; }
        public static String linkSource { get; } = "https://github.com/era90768/MediaPlayer-c-sharp-BT-13-05-2021";
        public static String linkProfile { get; } = "https://www.facebook.com/duyhieu.ndh/";
        public readonly static string AudioFilter = "All Supported Audio | *.mp3; *.wma; *.wav; *.m4a; *.ogg";
        public readonly static List<string> ArrayAudioFilter = new List<string>() { "mp3", "wma", "wav", "m4a", "ogg" };
        public readonly static string VideoFilter = "All Supported Video | *.mp4; *.m4v; *.mkv; *.mov; *.3gp; *.wmv";
        public readonly static List<string> ArrayVideoFilter = new List<string>() { "mp4", "m4v", "mkv", "mov", "3gp", "wmv" };

        public static void Init()
        {
            main = new MainForm();
            resources = new MyData();
        }

        public static void ConfigFolderBrowserDialog(FolderBrowserDialog openFolder)
        {
            openFolder.ShowNewFolderButton = true;
            //openFolder.SelectedPath = @"C:\";
            openFolder.Description = "Thêm thư mục chứa các file media" +
                "\nCác định dạng được hỗ trợ:\n   ";
            openFolder.Description += string.Join(", ", ArrayAudioFilter);
            openFolder.Description += ", " + string.Join(", ", ArrayVideoFilter);
        }
    }
}
