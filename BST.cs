namespace DSLabDotNetCore
{
    public class BST
    {
        private class BstNode
        {
            public BstNode(int data)
            {
                Data = data;
                Left = null;
                Right = null;
            }

            public int Data { get; set; }
            public BstNode Left { get; set; }
            public BstNode Right { get; set; }
        }
        public BST()
        {
            node = null;
        }

        public void Insert(int data)
        {
            node = Insert(this.node, data);
        }

        private BstNode Insert(BstNode node, int data)
        {
            if (node == null)
            {
                return new BstNode(data);
            }
            if (data < node.Data)
            {
                node.Left = Insert(node.Left, data);
            }
            else
            {
                node.Right = Insert(node.Right, data);
            }

            return node;
        }

        public bool Find(int data)
        {
            return Find(node, data) != null ? true : false;
        }

        private BstNode Find(BstNode node, int data)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Data == data) return node;

            if (data < node.Data)
            {
                return Find(node.Left, data);
            }

            return Find(node.Right, data);
        }

        private BstNode node;
    }
}