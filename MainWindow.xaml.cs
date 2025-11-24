using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFSystemprogramming1
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

        private void LaunchNotepad_Click(object sender, RoutedEventArgs e)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "notepad.exe",
                    UseShellExecute = false,
                    CreateNoWindow = false
                }
            };
            proc.Start();
            Thread.Sleep(3000);
            {
                if(!proc.HasExited)
                {
                    proc.Kill();
                }
            }
        }

        private void UpdateTextBox_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                string updateText = DateTime.Now.ToString();
                Dispatcher.Invoke(() => messageText.Text = updateText);
            });
        }
    }
}

                
     
