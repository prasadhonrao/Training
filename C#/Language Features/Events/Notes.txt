STEPS TO DECLARE AN EVENT USING CUSTOM DELEGATE

Declare a delegate.
Declare an event based on delegate declared in step 1.
Define a method in the class [Worker in this case] which raises the event. While raising an event, check of its nullness to ensure that there is at least on subscriber to the event.
In the client side, create instance of the class.
Associate the event with the event handler using +=.
Call the method declared in step 3, which raises the event