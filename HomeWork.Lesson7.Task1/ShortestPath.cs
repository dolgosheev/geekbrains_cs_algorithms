using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork.Lesson7.Task1
{
    /// <summary>
    /// shortest path algorithm ( Dijkstra’s )
    /// </summary>
    public class ShortestPath
    {
        private readonly Graph _graph;
        private readonly List<GraphVertexInfo> _vertexInfoList;

        // .ctor
        public ShortestPath(Graph graph)
        {
            _vertexInfoList = new List<GraphVertexInfo>();
            _graph = graph;
        }

        // init
        private void Initialize()
        {
            (_graph.VertexList).ForEach(r=> _vertexInfoList.Add(new GraphVertexInfo(r)));
        }

        // get vertex info
        private GraphVertexInfo GetVertexInfo(GraphVertex vertex)
        {
            foreach (var i in _vertexInfoList)
                if (i.Vertex.Equals(vertex))
                    return i;

            return null;
        }

        // Search for an unvisited vertex with a minimum sum value
        public GraphVertexInfo FindUnvisitedVertexWithMinSum()
        {
            var minValue = int.MaxValue;
            GraphVertexInfo minVertexInfo = null;
            foreach (var i in _vertexInfoList)
            {
                if (i.IsUnvisited && i.EdgesWeightSum < minValue)
                {
                    minVertexInfo = i;
                    minValue = i.EdgesWeightSum;
                }
            }

            return minVertexInfo;
        }

        // Find the shortest path by node name
        public string FindShortestPath(string startVotexName, string finishVortexName)
        {
            return FindShortestPath(_graph.FindVertex(startVotexName), _graph.FindVertex(finishVortexName));
        }

        // Find the shortest path on vertexes
        public string FindShortestPath(GraphVertex startVertex, GraphVertex finishVertex)
        {
            Initialize();
            var first = GetVertexInfo(startVertex);
            first.EdgesWeightSum = 0;
            while (true)
            {
                var current = FindUnvisitedVertexWithMinSum();
                if (current == null)
                {
                    break;
                }

                SetSumToNextVertex(current);
            }

            return GetPath(startVertex, finishVertex);
        }

        // calc sum of rib weights
        private void SetSumToNextVertex(GraphVertexInfo info)
        {
            info.IsUnvisited = false;
            foreach (var e in info.Vertex.RibsList)
            {
                var nextInfo = GetVertexInfo(e.LinkedVertex);
                var sum = info.EdgesWeightSum + e.RibWeight;
                if (sum < nextInfo.EdgesWeightSum)
                {
                    nextInfo.EdgesWeightSum = sum;
                    nextInfo.PreviousVertex = info.Vertex;
                }
            }
        }

        // path build
        private string GetPath(GraphVertex startVertex, GraphVertex endVertex)
        {
            var path = endVertex.ToString();
            var way = default(string);
            while (startVertex != endVertex)
            {
                endVertex = GetVertexInfo(endVertex).PreviousVertex;
                path = endVertex + " -> " + path;
            }

            return path;
        }
    }
}