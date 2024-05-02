using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK3
{
    internal class Class3
    {
        static void Main()
        {
            TreeNode root = new TreeNode(1);
            TreeNode child1 = new TreeNode(2);
            TreeNode child2 = new TreeNode(3);
            TreeNode grandchild1 = new TreeNode(4);
            TreeNode grandchild2 = new TreeNode(5);

            root.AddChild(child1);
            root.AddChild(child2);
            child1.AddChild(grandchild1);
            child1.AddChild(grandchild2);

            root.PrintChildrenValues();
        }
    }
}
