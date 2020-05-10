using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMayChallengeDay7
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool IsCousins(TreeNode root, int x, int y)
        {
            var ltree = root.left;
            var rtree = root.right;
            while (ltree != null && rtree != null)
            {
                if ((ltree.val == x || ltree.val == y)
                   && rtree.val == x || rtree.val == y)
                {
                    return true;
                }

                ltree = ltree.left;
                rtree = ltree.right;
            }
            return false;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

}
