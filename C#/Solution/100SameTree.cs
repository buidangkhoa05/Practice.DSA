using Practice.DSA.Model;

namespace Practice.DSA.Solution
{
    internal class _100SameTree()
    {

        // Solution 2 ==================================================================================
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
                
            if (p?.val != q?.val)
                return false;

            return true 
                && IsSameTree(p.left, q.left) 
                && IsSameTree(p.right, q.right);
        }
        //Solution 1  ==================================================================================
        public bool IsSameTreeSolution1(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            else if (p == null && q != null)
                return false;
            else if (p != null && q == null)
                return false;

            var queue = new Queue<int?>();

            ScanFirstTreeWithDFS(p, queue);

            foreach (var item in queue)
            {
                Console.Write(item);
            }

            var res = ScanSecondTreeWithDFS(q, queue);

            return res && queue.TryDequeue(out _) == false;
        }

        private void ScanFirstTreeWithDFS(TreeNode treeNode, Queue<int?> queue)
        {
            queue.Enqueue(treeNode.val);

            // Console.WriteLine(treeNode.val);

            if (treeNode.left != null)
                ScanFirstTreeWithDFS(treeNode.left, queue);
            else
                queue.Enqueue(null);

            if (treeNode.right != null)
                ScanFirstTreeWithDFS(treeNode.right, queue);
            else
                queue.Enqueue(null);
        }

        private bool ScanSecondTreeWithDFS(TreeNode treeNode, Queue<int?> queue)
        {
            Console.WriteLine(treeNode.val);

            if (queue.TryDequeue(out int? value) == false)
                return false;

            if (value != treeNode.val)
                return false;

            var res = true;

            if (treeNode.left != null)
                res = ScanSecondTreeWithDFS(treeNode.left, queue);
            else
                res = queue.TryDequeue(out value) == true && value == null;

            if (!res)
                return res;

            if (treeNode.right != null)
                res &= ScanSecondTreeWithDFS(treeNode.right, queue);
            else
                res &= queue.TryDequeue(out value) == true && value == null;

            return res;
        }

    }
}
