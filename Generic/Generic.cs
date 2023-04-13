namespace Generic
{
    public class Generic<T>
    {
        public T Value { get; set; }
        public T Value2 { get; set; }
        public void GenericSum(T obj1, T obj2)
        {
            Value = obj1;
            Value2 = obj2;
        }
    }
}
