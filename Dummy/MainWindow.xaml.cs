using Microsoft.Win32;
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
using System.Windows.Threading;

namespace Dummy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MediaPlayer.Width = this.Width - 15;
            MediaPlayer.Height = this.Height - 55;
            toolMenu.Width = this.Width;
        }        

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            MediaPlayer.Width = this.Width - 15;
            MediaPlayer.Height = this.Height - 55;
            toolMenu.Width = this.Width;
        }        

        protected override void OnStateChanged(EventArgs e)
        {
            MediaPlayer.Width = this.Width - 15;
            MediaPlayer.Height = this.Height - 55;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            /// on the client
            OpenFileDialog opf = new OpenFileDialog
            {
                Title = "Choose a Media File",
                Filter = "Songs, Videos|*.mp3;*.mp4;*.wav;*.avi"
            };
            bool? result = opf.ShowDialog();
            if(result == true)
            {
                this.Title = "XPlayer - " + System.IO.Path.GetFileName(opf.FileName);
                MediaPlayer.FileName = opf.FileName;
                MediaPlayer.PlayMedia();
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }        

        //private void TimeFunction()
        //{
        //    if(secs < 59)
        //    {
        //        secs++;
        //    }
        //    else
        //    {
        //        secs = 0;
        //        if(mins < 59)
        //        {
        //            mins++;
        //        }
        //        else
        //        {
        //            mins = 0;
        //            hours++;
        //        }
        //    }
        //}
    }
}
