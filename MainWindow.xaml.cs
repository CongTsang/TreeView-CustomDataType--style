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

namespace WpfApp2
{
    /// <summary>
    /// 判断是否是构造当前层的最后一个元素
    /// </summary>
    public class TreeViewLineConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            TreeViewItem item = (TreeViewItem)value;
            ItemsControl ic = ItemsControl.ItemsControlFromItemContainer(item);
            //System.Console.WriteLine(ic.Items.Count + "  " + item.Header.ToString());
            return ic.ItemContainerGenerator.IndexFromContainer(item) == ic.Items.Count - 1;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return false;
        }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
            InitDataSource();
		}

        /// <summary>
        /// 树形结构内容加载（初始化时调用即可）
        /// </summary>
        private void InitDataSource()
        {
            TreeViewItemIPU root = new TreeViewItemIPU() { TreeViewItemName = "Root" };
            TreeViewItemIPU childLevel1 = new TreeViewItemIPU() { TreeViewItemName = "childLevel1" };


            TreeViewItemIPU childLevel1_1 = new TreeViewItemIPU() { TreeViewItemName = "childLevel1_1" };
            TreeViewItemIPU childLevel1_1_1 = new TreeViewItemIPU() { TreeViewItemName = "childLevel1_1_1" };
            TreeViewItemIPU childLevel1_1_2 = new TreeViewItemIPU() { TreeViewItemName = "childLevel1_1_2" };
            TreeViewItemIPU childLevel1_1_1_1 = new TreeViewItemIPU() { TreeViewItemName = "childLevel1_1_1_1" };
            TreeViewItemIPU childLevel1_1_1_2 = new TreeViewItemIPU() { TreeViewItemName = "childLevel1_1_1_2" };
            TreeViewItemIPU childLevel1_1_1_3 = new TreeViewItemIPU() { TreeViewItemName = "childLevel1_1_1_3" };
            TreeViewItemIPU childLevel1_1_1_4 = new TreeViewItemIPU() { TreeViewItemName = "childLevel1_1_1_4" };
            childLevel1_1_1.Children.Add(childLevel1_1_1_1);
            childLevel1_1_1.Children.Add(childLevel1_1_1_2);
            childLevel1_1_1.Children.Add(childLevel1_1_1_3);
            childLevel1_1_1.Children.Add(childLevel1_1_1_4);
            childLevel1_1.Children.Add(childLevel1_1_1);
            childLevel1_1.Children.Add(childLevel1_1_2);

            TreeViewItemIPU childLevel1_2 = new TreeViewItemIPU() { TreeViewItemName = "childLevel1_2" };
            TreeViewItemIPU childLevel1_2_1 = new TreeViewItemIPU() { TreeViewItemName = "childLevel1_2_1" };
            TreeViewItemIPU childLevel1_2_2 = new TreeViewItemIPU() { TreeViewItemName = "childLevel1_2_2" };
            childLevel1_2.Children.Add(childLevel1_2_1);
            childLevel1_2.Children.Add(childLevel1_2_2);

            childLevel1.Children.Add(childLevel1_1);
            childLevel1.Children.Add(childLevel1_2);

            TreeViewItemIPU childLevel2 = new TreeViewItemIPU() { TreeViewItemName = "childLevel2" };
            TreeViewItemIPU childLevel2_1 = new TreeViewItemIPU() { TreeViewItemName = "childLevel2_1" };
            TreeViewItemIPU childLevel2_2 = new TreeViewItemIPU() { TreeViewItemName = "childLevel2_2" };
            TreeViewItemIPU childLevel2_3 = new TreeViewItemIPU() { TreeViewItemName = "childLevel2_3" };
            TreeViewItemIPU childLevel2_4 = new TreeViewItemIPU() { TreeViewItemName = "childLevel2_4" };
            childLevel2.Children.Add(childLevel2_1);
            childLevel2.Children.Add(childLevel2_2);
            childLevel2.Children.Add(childLevel2_3);
            childLevel2.Children.Add(childLevel2_4);

            root.Children.Add(childLevel1);
            root.Children.Add(childLevel2);

            treeView_Set.Items.Add(root);
        }
    }

}
