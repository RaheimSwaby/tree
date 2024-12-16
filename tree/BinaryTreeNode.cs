using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tree
{
    public class BinaryTreeNode<T> : TreeNode<T>
    {
        public new BinaryTreeNode<T>?[] Children { get; set; }
        = [null, null];
        public BinaryTreeNode<T>? Left
        {
            get { return Children[0]; }
            set { Children[0] = value; }
        }
        public BinaryTreeNode<T>? Right
        {
            get { return Children[1]; }
            set { Children[1] = value; }
        }
    }
    public class TreeNode<T>
    {
        public T? Data { get; set; }
        public TreeNode<T> Parent { get; set; }
        public List<TreeNode<T>> Children { get; set; } = [];
        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }
    }
    public class Tree<T>
    {
        public TreeNode<T>? Root { get; set; }
    }
}
