using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WebEye.Controls.WinForms.WebCameraControl;

namespace WPFMetaVLC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<WebCameraId> cameras = new List<WebCameraId>(webCameraControl1.GetVideoCaptureDevices());
            webCameraControl1.StartCapture(cameras[0]);
            Bitmap image = webCameraControl1.GetCurrentImage();
            //MediaPlayer player = new MediaPlayer();
            //player.Open(new Uri("device://dshow/?video=HP TrueVision HD Camera", UriKind.Absolute));
            //mediaElement.

            //VideoDrawing drawing = new VideoDrawing();
            //drawing.Rect = new Rect(0, 0, 100, 100);
            //drawing.Player = player;
            //player.Play();
        }
    }
}
