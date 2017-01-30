namespace Mutable_Immutable
{
    public class ObservableImmutable
    {
        private int cachedHash;
        public string Name { get;}

        public ObservableImmutable(string name)
        {
            this.Name = name;
        }

        public override bool Equals(object obj)
        {
            var other = obj as ObservableImmutable;
            if(other == null)
            {
                return false;
            }
            return other.Name == Name;
        }

        public override int GetHashCode()
        {
            if (cachedHash == 0 )
            {
                cachedHash = Name.GetHashCode();
            }
            return cachedHash;
        }
    }
}
