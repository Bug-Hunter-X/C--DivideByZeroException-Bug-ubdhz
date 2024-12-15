public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // The following line will throw an exception if MyProperty is 0
        int result = 10 / MyProperty; 
    }
}