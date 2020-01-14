using System;
using System.Collections.Generic;
using System.IO;
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

namespace DatabaseFiles
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

        private void Add(object sender, RoutedEventArgs e)
        {
            
        }

        private void Delete(object sender, RoutedEventArgs e)
        {

        }

        private void MouseClickFiles(object sender, MouseButtonEventArgs e)
        {
            DirectoryInfo dirinf = new DirectoryInfo(@"C:\Users\ЕсентайА\Desktop");
            FileInfo[] fileinfo = dirinf.GetFiles();
            using(var context = new Context())
            {
                foreach (FileInfo fi in fileinfo)
                {
                    var file = new File
                    {
                        Name = fi.ToString()
                    };
                    listBoxFiles.Items.Add(fi.ToString());
                    context.Add(file);
                }
                context.SaveChanges();
            }
        }
    }
}
