using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using System.IO;

namespace VideoSubtitler
{
    public partial class VideoView : System.Windows.Forms.UserControl
    {
        public VideoView()
        {
            InitializeComponent();
        }

        private MediaElement MediaElement{
            get {
                return videoHolder1.mediaElement;
            }
        }

        public TimeSpan Length {
            get {
                if (MediaElement.NaturalDuration.HasTimeSpan) {
                    return MediaElement.NaturalDuration.TimeSpan;
                }
                return TimeSpan.FromMilliseconds(1);
            }
        }

        public int LengthInt {
            get {
                return (int)Length.TotalMilliseconds;
            }
        }

        public TimeSpan Position {
            get {
                return MediaElement.Position;
            }
            set {
                MediaElement.Position = value;
            }
        }

        public int PositionInt {
            get {
                return (int)Position.TotalMilliseconds;
            }
            set {
                Position = TimeSpan.FromMilliseconds(value);
            }
        }

        public bool IsPlaying {
            get {
                return _isPlaying;
            }
        }

        public double PlayBackSpeed {
            get {
                return MediaElement.SpeedRatio;
            }
            set
            {
                MediaElement.SpeedRatio=value;
            }
        }

        public void SetVideoFile(string videoFile) {
            FileInfo file = new FileInfo(videoFile);
            Uri u = null;
            if (Uri.TryCreate(file.FullName, UriKind.Absolute, out u))
            {
                MediaElement.Source = u;
                _isPlaying = false;
                Play();
                Stop();
            }
            else {
                throw new InvalidOperationException("Cannot setup the video");
            }
        }

        private bool _isPlaying = false;
        private bool _isEnded = false;

        public void Play() {
            if (_isEnded) {
                MediaElement.Stop();
            }
            MediaElement.Play();
            _isEnded = false;
            if (_isPlaying != true)
            {
                _isPlaying = true;
                PlayStateChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public void Stop() {
            MediaElement.Pause();
            if (_isPlaying != false)
            {
                _isPlaying = false;
                PlayStateChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void VideoView_Load(object sender, EventArgs e)
        {
            MediaElement.MediaEnded += MediaElement_MediaEnded;
        }

        private void MediaElement_MediaEnded(object sender, System.Windows.RoutedEventArgs e)
        {
            _isEnded = true;
            _isPlaying = false;
            MediaElement.Pause();
            PlayStateChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler<EventArgs> PlayStateChanged;
        private void ElementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
