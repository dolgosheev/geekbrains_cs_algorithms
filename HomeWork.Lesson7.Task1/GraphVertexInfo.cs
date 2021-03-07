namespace HomeWork.Lesson7.Task1
{
    public class GraphVertexInfo
    {
        // vertex
        public GraphVertex Vertex { get; set; }

        // unvisited vertex
        public bool IsUnvisited { get; set; }

        // Sum of rib weights
        public int EdgesWeightSum { get; set; }

        // prev vertex
        public GraphVertex PreviousVertex { get; set; }

        // .ctor
        public GraphVertexInfo(GraphVertex vertex)
        {
            Vertex = vertex;
            IsUnvisited = true;
            EdgesWeightSum = int.MaxValue;
            PreviousVertex = null;
        }
    }
}