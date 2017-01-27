namespace CircularBuffer
{
    public class CircularBuffer<T>
    {
        private T[] buffer;
        int start;
        int end;

        public CircularBuffer() : this(capacity: 10)
        {

        }

        public CircularBuffer(int capacity)
        {
            buffer = new T[capacity + 1];
            start = 0;
            end = 0;
        }

        public void Add(T value)
        {
            buffer[end] = value;
            end = (end + 1) % buffer.Length;

            if (end == start)
            {
                start = (start + 1) % buffer.Length;
            }
        }

        public T Read()
        {
            T result = buffer[start];
            start = (start + 1) % buffer.Length;
            return result;
        }

        public bool IsFull
        {
            get { return (end + 1) % buffer.Length == start; }
        }

        public bool IsEmpty
        {
            get { return end == start; }
        }

        public int Capacity
        {
            get { return buffer.Length; }
        }


    }
}
