using System;

namespace HomeWork.Lesson6.Task2
{
    public class BinNode<T> where T : IComparable
    {
        public T Data { get; set; }
        public int Level { get; set; }
        public BinNode<T> LeftNode { get; set; }
        public BinNode<T> RightNode { get; set; }
        public BinNode<T> ParentNode { get; set; }
        public Side? NodeSide =>
            ParentNode == null ?
                (Side?)null
                : ParentNode.LeftNode == this
                    ? Side.Left
                    : Side.Right;

        public BinNode(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}