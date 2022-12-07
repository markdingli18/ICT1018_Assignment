namespace DS
{
    public class SOEReturnObject
    {
        public int Maximum { get; set; }
        public int Count { get; set; }
    }

    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node()
        {

        }
        public Node(int data)
        {
            this.Data = data;
        }
    }

    public class Pair
    {

        public int first, second;

        public Pair(int f, int s)
        {
            first = f;
            second = s;
        }
    };
}
