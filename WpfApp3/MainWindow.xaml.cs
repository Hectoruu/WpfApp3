using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows;

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string exePath = System.IO.Path.GetFullPath(
                    @"..\..\..\ConsoleApp1\ConsoleApp1\bin\Debug\net8.0\ConsoleApp1.exe");

                if (File.Exists(exePath))
                {
                    Process.Start(exePath);
                }
                else
                {
                    MessageBox.Show("ConsoleApp1.exe not found at:\n" + exePath,
                        "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
    }
