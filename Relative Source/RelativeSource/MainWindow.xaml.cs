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

namespace RelativeSource
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Item> LstItem = new List<Item>();

            LstItem.Add(new Item() { Data = 100 });
            LstItem.Add(new Item() { Data = 130 });
            LstItem.Add(new Item() { Data = 150 });

            DataContext = LstItem;
        }
    }

    public class Item
    {
        public int Data { get; set; }
    }
}
