using System.Collections.Generic;

namespace HomeWork.Lesson7.Task1
{
    public class GraphVertex
    {
        public string Title { get; }

        // Ribs List
        public List<GraphRib> RibsList { get; }

        // .ctor
        public GraphVertex(string vertexName)
        {
            Title = vertexName;
            RibsList = new List<GraphRib>();
        }

        // Rib addition
        public void RibAddition(GraphRib newRib)
        {
            RibsList.Add(newRib);
        }

        // Rib addition | overload
        public void RibAddition(GraphVertex vertex, int ribWeight)
        {
            RibAddition(new GraphRib(vertex, ribWeight));
        }

        public override string ToString()
        {
            return Title;
        }
    }
}