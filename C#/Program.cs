using Practice.DSA.Model;
using Practice.DSA.Solution;

namespace Practice.DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nodeTree = new TreeNode
            {
                val = 2,
                left = new TreeNode
                {
                    val = 1
                },
                right = new TreeNode 
                {
                    val = 3
                }
            };

            var res = new _100SameTree().IsSameTree(nodeTree, nodeTree);

            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
