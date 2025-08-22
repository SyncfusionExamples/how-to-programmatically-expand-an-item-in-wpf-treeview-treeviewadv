# How to programmatically expand an item in WPF TreeViewAdv

This sample shows how to programmatically expand an item in [WPF TreeView](https://help.syncfusion.com/wpf/classic/treeview/overview) (TreeViewAdv).

`TreeViewAdv` allows to expand or collapse each node by setting [IsExpanded](https://help.syncfusion.com/cr/wpf/Syncfusion.Windows.Tools.Controls.TreeViewItemAdv.html#Syncfusion_Windows_Tools_Controls_TreeViewItemAdv_IsExpanded) property.

``` csharp
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
```