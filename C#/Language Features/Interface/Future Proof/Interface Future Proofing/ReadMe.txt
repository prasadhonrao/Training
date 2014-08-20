Program to abstraction rather than concrete type.

In the example, if we change return type of GetUsingConcreteClass method from Employee[] to List<Employee>, it breaks the client. To follow the principle, we should rather return IEnumerable since both Array & List inherits to IEnumerable.
