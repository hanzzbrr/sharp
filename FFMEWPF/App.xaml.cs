using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FFMEWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Unosquare.FFME.Library.FFmpegDirectory = @"c:\ffmpeg\bin";
            Unosquare.FFME.Library.LoadFFmpeg();
            Unosquare.FFME.MediaElement.FFmpegMessageLogged += (s, ev) =>
            {
                System.Diagnostics.Debug.WriteLine("ev message: " + ev.Message);
            };
            base.OnStartup(e);
        }
    }
}
