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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.Windows.Tools;
using Syncfusion.Windows.Tools.Controls;

namespace treeViewAdv
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TreeViewAdv treeViewAdv = new TreeViewAdv();
            TreeViewItemAdv root1 = new TreeViewItemAdv() { Header = "Marital Status" };
            TreeViewItemAdv subitem11 = new TreeViewItemAdv() { Header = "Single" };
            TreeViewItemAdv subitem12 = new TreeViewItemAdv() { Header = "Married" };
            TreeViewItemAdv subitem13 = new TreeViewItemAdv() { Header = "Married with Children" };

            root1.Items.Add(subitem11);
            root1.Items.Add(subitem12);
            root1.Items.Add(subitem13);

            TreeViewItemAdv root2 = new TreeViewItemAdv() { Header = "Baby Vaccines" };
            TreeViewItemAdv subitem21 = new TreeViewItemAdv() { Header = "Hepatitis B" };
            TreeViewItemAdv subitem22 = new TreeViewItemAdv() { Header = "Tetanus" };
            TreeViewItemAdv subitem23 = new TreeViewItemAdv() { Header = "Polio" };
            TreeViewItemAdv subitem24 = new TreeViewItemAdv() { Header = "Measles" };

            root2.Items.Add(subitem21);
            root2.Items.Add(subitem22);
            root2.Items.Add(subitem23);
            root2.Items.Add(subitem24);

            TreeViewItemAdv root3 = new TreeViewItemAdv() { Header = "Baby Vaccines" };

            treeViewAdv.Items.Add(root1);
            treeViewAdv.Items.Add(root2);
            treeViewAdv.Items.Add(root3);
            Grid.Children.Add(treeViewAdv);

            root1.IsExpanded = true;
        }
    }
}
