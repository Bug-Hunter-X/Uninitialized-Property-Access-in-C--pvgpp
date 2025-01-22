public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Solution: Initialize MyProperty with a default value

    public void MyMethod()
    {
        int value = MyProperty * 2; // Now, MyProperty is guaranteed to have a value
    }
}
//Alternatively
public class ExampleClass
{
    private int _myProperty;
    public int MyProperty
    {
        get => _myProperty;
        set => _myProperty = value;
    }
    public void MyMethod()
    {
        //Access to myProperty before it is initialized would result in default value 0
        _myProperty = 10;
        int value = MyProperty * 2; 
    }
}