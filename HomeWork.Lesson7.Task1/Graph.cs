using System.Collections.Generic;

namespace HomeWork.Lesson7.Task1
{
    public class Graph
    {
        // List of vertex
        public List<GraphVertex> VertexList { get; }

        // .ctor
        public Graph()
        {
            VertexList = new List<GraphVertex>();
        }

        // Vertex addition
        public void AddVertex(params string[] vertexNames)
        {
            foreach (var vertexName in vertexNames)
                VertexList.Add(new GraphVertex(vertexName));
        }

        // Vertex search
        public GraphVertex FindVertex(string vertexName)
        {
            foreach (var v in VertexList)
                if (v.Title.Equals(vertexName))
                    return v;

            return null;
        }

        // Rib addition
        public void RibAddition(string firstVertexName, string secondVertexName, int concatedRibWeight)
        {
            var firstVertex = FindVertex(firstVertexName);
            var secondVertex = FindVertex(secondVertexName);
            if (secondVertex != null && firstVertex != null)
            {
                firstVertex.RibAddition(secondVertex, concatedRibWeight);
                secondVertex.RibAddition(firstVertex, concatedRibWeight);
            }
        }
    }
}