public partial class SinglyLinkedList<T>
{
    private class Node
    {
        public T? Value { get; }
        public Node? Next { get; set; }

        public Node(T? value)
        {
            Value = value;
        }

        public override string ToString() =>
            $"Value: {Value}, " +
            $"Next: {(Next is null ? "null" : Next.Value)}";
    }
}
