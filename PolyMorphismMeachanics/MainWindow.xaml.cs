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

namespace PolyMorphismMeachanics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Shape[] shapes = new Shape[10];
        public MainWindow()
        {
            InitializeComponent();
            shapes = FillArray();
        }

        public Shape[] FillArray()
        {
            Shape[] arr = new Shape[10];
            arr[0] = new Circle(6, 50, 70);
            arr[1] = new Circle(2, 15, 15);
            arr[2] = new Rectangle(8, 12, 56, 155);
            arr[3] = new Cylinder(5, 4, 72, 66);
            arr[4] = new Rectangle(20, 2, 250, 101);
            arr[5] = new Triangle(8, 8, 137, 83);
            arr[6] = new Cylinder(3, 8, 23, 24);
            arr[7] = new Block(2, 6, 5, 12, 51);
            arr[8] = new Triangle(2, 12, 152, 251);
            arr[9] = new Circle(2, 211, 111);
            return arr;
        }

        private void BtnShow_Click(object sender, RoutedEventArgs e)
        {
            double total = 0;
            int count = 0;
            foreach(Shape s in shapes)
            {
                TextBlock newtb = new TextBlock();
                newtb.Text = s.GetArea().ToString();
                stkAreas.Children.Add(newtb);
                count++;
                total += s.GetArea();
                txbTotal.Text = string.Format("Total: {0}", total.ToString("n2"));
            }
        }
    }
}
