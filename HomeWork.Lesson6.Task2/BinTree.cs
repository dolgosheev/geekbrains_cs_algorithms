using System;

namespace HomeWork.Lesson6.Task2
{
    public class BinTree<T> where T : IComparable
    {
        private int _maxLevel;
        private BinNode<T> _rootNode;

        // Filler
        public BinTree(params T[] data)
        {
            foreach (var r in data)
                Add(new BinNode<T>(r));
        }

        // Add member to root node
        public BinNode<T> Add(BinNode<T> node, BinNode<T> currentNode = null)
        {
            if (_rootNode == null)
            {
                node.ParentNode = null;
                node.Level = 1;
                return _rootNode = node;
            }

            currentNode = currentNode ?? _rootNode;
            node.ParentNode = currentNode;
            node.Level = node.ParentNode.Level++;
            if (node.Level > _maxLevel) _maxLevel = node.Level;
            int result;
            return (result = node.Data.CompareTo(currentNode.Data)) == 0 ?
                currentNode :
                result < 0 ?
                    currentNode.LeftNode == null ? currentNode.LeftNode = node : Add(node, currentNode.LeftNode)
                    : currentNode.RightNode == null ? currentNode.RightNode = node : Add(node, currentNode.RightNode);
        }


        // Remove method | logic
        public void Remove(BinNode<T> node)
        {
            if (node == null)
                return;

            var currentNodeSide = node.NodeSide;

            // delete if has not contains subnodes
            if (node.LeftNode == null && node.RightNode == null)
            {
                if (currentNodeSide == Side.Left)
                    node.ParentNode.LeftNode = null;
                else
                    node.ParentNode.RightNode = null;
            }
            // Right to removal site ( if there is no left )
            else if (node.LeftNode == null)
            {
                if (currentNodeSide == Side.Left)
                    node.ParentNode.LeftNode = node.RightNode;
                else
                    node.ParentNode.RightNode = node.RightNode;

                node.RightNode.ParentNode = node.ParentNode;
            }
            // Left to removal site ( if there is no right )
            else if (node.RightNode == null)
            {
                if (currentNodeSide == Side.Left)
                    node.ParentNode.LeftNode = node.LeftNode;
                else
                    node.ParentNode.RightNode = node.LeftNode;

                node.LeftNode.ParentNode = node.ParentNode;
            }
            // If both are present, right to remove, left to right
            else
            {
                switch (currentNodeSide)
                {
                    case Side.Left:
                        node.ParentNode.LeftNode = node.RightNode;
                        node.RightNode.ParentNode = node.ParentNode;
                        Add(node.LeftNode, node.RightNode);
                        break;
                    case Side.Right:
                        node.ParentNode.RightNode = node.RightNode;
                        node.RightNode.ParentNode = node.ParentNode;
                        Add(node.LeftNode, node.RightNode);
                        break;
                    default:
                        var bufLeft = node.LeftNode;
                        var bufRightLeft = node.RightNode.LeftNode;
                        var bufRightRight = node.RightNode.RightNode;
                        node.Data = node.RightNode.Data;
                        node.RightNode = bufRightRight;
                        node.LeftNode = bufRightLeft;
                        Add(bufLeft, node);
                        break;
                }
            }
        }
        public void Remove(T data)
        {
            var foundNode = FindNode(data);
            Remove(foundNode);
        }

        // Find member
        public BinNode<T> FindNode(T data, BinNode<T> startWithNode = null)
        {
            startWithNode = startWithNode ?? _rootNode;
            int result;
            return (result = data.CompareTo(startWithNode.Data)) == 0 ?
                startWithNode
                : result < 0 ?
                    startWithNode.LeftNode == null ?
                        null
                        : FindNode(data, startWithNode.LeftNode)
                    : startWithNode.RightNode == null
                        ? null
                        : FindNode(data, startWithNode.RightNode);
        }

        // method for public access
        public void PrintTree()
        {
            Console.WriteLine("Output \"pseudoTree\"");
            PrintTree(_rootNode);
        }

        // Encapsulated overloaded nethod | show tree
        private void PrintTree(BinNode<T> startNode, string indent = "", Side? side = null)
        {
            if (startNode != null)
            {
                const int indentStep = 1;
                var delim = indent == "" ? "" : ":";
                var maxLevel = indent == "" ? $" (max.height:{_maxLevel - 1})" : "";
                var nodeLevel = indent != "" ? $" (level:{startNode.Level})" : "";
                var nodeSide = side == null ? "" : side == Side.Left ? "L" : "R";
                Console.Write($"{startNode.Level}|");
                Console.WriteLine($"{indent}{nodeSide}{delim}{startNode.Data}{maxLevel}{nodeLevel}");
                indent += new string(' ', indentStep);
                // recursive call for left branch
                PrintTree(startNode.LeftNode, indent, Side.Left);
                // recursive call for right branch
                PrintTree(startNode.RightNode, indent, Side.Right);
            }
        }

        // Walk tree variants
        public void PrintTreeСircumvent(Type type)
        {
            switch ((int)type)
            {
                case (0):
                    Console.Write($"RootLeftRight: ");
                    PrintTreeRootLr(_rootNode);
                    break;
                case (1):
                    Console.Write($"LeftRootRight: ");
                    PrintTreeLRootR(_rootNode);
                    break;
                case (2):
                    Console.Write($"LeftRightRoot: ");
                    PrintTreeLrRoot(_rootNode);
                    break;
                default:
                    Console.Write($"\nSkip Tree: ");
                    break;
            }
            Console.WriteLine("");
        }

        // walk root-left-right
        public void PrintTreeRootLr(BinNode<T> startNode)
        {
            if (startNode != null)
            {
                Console.Write(startNode.Data);
                PrintTreeRootLr(startNode.LeftNode);
                PrintTreeRootLr(startNode.RightNode);
            }
        }

        // walk left-root-right
        public void PrintTreeLRootR(BinNode<T> startNode)
        {
            if (startNode != null)
            {
                PrintTreeLRootR(startNode.LeftNode);
                Console.Write(startNode.Data);
                PrintTreeLRootR(startNode.RightNode);
            }
        }

        // walk left-right-root
        public void PrintTreeLrRoot(BinNode<T> startNode)
        {
            if (startNode != null)
            {
                PrintTreeLrRoot(startNode.LeftNode);
                PrintTreeLrRoot(startNode.RightNode);
                Console.Write(startNode.Data);
            }
        }
    }
}