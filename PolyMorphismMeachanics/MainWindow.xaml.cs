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
        Shape[] _Shapes = new Shape[10];

        public MainWindow()
        {
            InitializeComponent();
            _Shapes = FillArray();
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
            foreach (Shape s in _Shapes)
            {
                TextBlock newtb = new TextBlock();
                newtb.Text = s.GetArea().ToString();
                stkAreas.Children.Add(newtb);
                count++;
                total += s.GetArea();
                txbTotal.Text = string.Format("Total: {0}", total.ToString("n2"));
            }
        }

        private void BtnSum_Click(object sender, RoutedEventArgs e)
        {
            IVolume[] volumes = new IVolume[4];            volumes[0] = new Cylinder(10, 45, 5, 15);
            volumes[1] = new Block(13, 16, 12, 5, 15);
            volumes[2] = new Cylinder(10, 45, 5, 15);
            volumes[3] = new Block(24, 72, 3, 5, 15);
            double sumTotal = 0;
            foreach (IVolume vol in volumes)
            {
                sumTotal += vol.GetVolume();
            }
            txbInterTotal.Text = string.Format("Total: {0}", sumTotal.ToString("n5"));
        }

        private void BtnGetShapes_Click(object sender, RoutedEventArgs e)
        {
            int cirCount = 0, rectCount = 0, triCount = 0,cylCount = 0, blkCount = 0;
            foreach (Shape sh in _Shapes)
            {
                TextBlock tb = new TextBlock();
                if (sh.GetType() == typeof(Circle))
                {
                    cirCount++;
                    tb.Text = "Circle";
                }
                else if (sh.GetType() == typeof(Rectangle))
                {
                    rectCount++;
                    tb.Text = "Rectangle";
                }
                else if (sh.GetType() == typeof(Triangle))
                {
                    triCount++;
                    tb.Text = "Triangle";
                }
                else if (sh.GetType() == typeof(Cylinder))
                {
                    cylCount++;
                    tb.Text = "Cylinder";
                }
                else if (sh.GetType() == typeof(Block))
                {
                    blkCount++;
                    tb.Text = "Block";
                }
                else
                {
                    tb.Text = "Unknown Shape";
                }
                stkShapesList.Children.Add(tb);
            }
            txbBlock.Text += blkCount.ToString();
            txbCircle.Text += cirCount.ToString();
            txbCylinder.Text += cylCount.ToString();
            txbRectangle.Text += rectCount.ToString();
            txbTriangle.Text += triCount.ToString();
        }
    }
}
