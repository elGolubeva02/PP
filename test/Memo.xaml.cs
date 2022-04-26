using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace test
{
    /// <summary>
    /// Логика взаимодействия для Memo.xaml
    /// </summary>
    public partial class Memo : Window
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Memo()
        {
            InitializeComponent();
            _timer = new DispatcherTimer();
            _timer.Tick += delegate
            {
                var now = DateTime.Now;
                var elapsed = now.Subtract(_startCountdown);
                TimeToEnd = _startTimeSpan.Subtract(elapsed);
            };
            StopTimer();
        }
        private DateTime _startCountdown;
        private TimeSpan _startTimeSpan = TimeSpan.FromSeconds(5);
        private TimeSpan _timeToEnd;
        private DispatcherTimer _timer;
        public TimeSpan TimeToEnd
        {
            get
            {
                return _timeToEnd;
            }
            set
            {
                _timeToEnd = value;
                if (value.TotalMilliseconds <= 0)
                {
                    StopTimer();
                    this.Close();
                }
                OnPropertyChanged("StringCountdown");
            }
        }
        public string StringCountdown
        {
            get
            {
                var frmt = TimeToEnd.Minutes < 1 ? "ss\\.ff" : "mm\\:ss";
                return _timeToEnd.ToString(frmt);
            }
        }
        public bool TimerIsEnabled
        {
            get { return _timer.IsEnabled; }
        }
        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        private void StopTimer()
        {
            if (TimerIsEnabled)
                _timer.Stop();
            TimeToEnd = _startTimeSpan;
        }
        private void StartTimer(DateTime sDate)
        {
            _startCountdown = sDate;
            _timer.Start();
        }
    }
}
