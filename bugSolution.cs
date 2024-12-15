public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Check for zero before dividing
        if (MyProperty != 0)
        {
            int result = 10 / MyProperty; 
        }
        else
        {
            // Handle the case where MyProperty is 0
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}