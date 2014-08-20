namespace ExplicitImplementation
{
    // Two different interface with same method name but different return type. 
    // Return type can be same or different, concrete can wont show overloading error as long as interface methods are implemented explicitely.

    interface IPersistable
    {
        string Save();

        string Load();
    }

    interface ISaveable
    {
        void Save();
    }
}
