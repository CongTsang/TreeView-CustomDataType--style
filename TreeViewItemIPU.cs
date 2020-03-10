using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WpfApp2
{
    /// <summary>
    /// 可视化树节点的结构定义
    /// </summary>
    public class TreeViewItemIPU
    {
        private string _treeViewItemName;
        public string TreeViewItemName
        {
            get { return _treeViewItemName; }
            set { _treeViewItemName = value; }
        }
        private ObservableCollection<TreeViewItemIPU> _children = new ObservableCollection<TreeViewItemIPU>();
        public ObservableCollection<TreeViewItemIPU> Children
        {
            get
            {
                return _children;
            }
            set
            {
                if (value != _children)
                {
                    _children = value;
                }
            }
        }

    }
}
