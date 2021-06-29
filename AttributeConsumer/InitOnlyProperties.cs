namespace AttributeConsumer
{
    public record R1(int X);
    internal record R2(int X, string Y);

    public class C1
    {
        public int X { get; init; }
    }
}
