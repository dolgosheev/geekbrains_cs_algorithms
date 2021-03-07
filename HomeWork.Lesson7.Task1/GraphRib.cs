namespace HomeWork.Lesson7.Task1
{
    public class GraphRib
    {
        // linked vertex
        public GraphVertex LinkedVertex { get; }

        // Rib weight
        public int RibWeight { get; }

        // .ctor
        public GraphRib(GraphVertex connectedVertex, int weight)
        {
            LinkedVertex = connectedVertex;
            RibWeight = weight;
        }
    }
}