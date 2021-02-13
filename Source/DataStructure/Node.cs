namespace DataStructure
{
    public class Node
    {
        public Node(int _data, Node _leftChild = null, Node _rightChild = null)
        {
            Data = _data;
            LeftChild = _leftChild;
            RightChild = _rightChild;
        }
        public int Data { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
    }
}
