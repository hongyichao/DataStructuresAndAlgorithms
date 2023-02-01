
namespace LinearStructures.LinkedList
{
    public class Node
    {
        public int value { get; set; }
        public Node? next { get; set; }

        public Node(int value) 
        {
            this.value = value;
            next = null;
        }

        public override string ToString()
        {
            return Convert.ToString(this.value);
        }
    }
}
