# Uninitialized Property Access in C#

This example showcases a common error in C#: accessing a class property before it's been assigned a value.  The `MyProperty` in `ExampleClass` is used in the `MyMethod` without an initial value. This could lead to unpredictable results or runtime exceptions. The solution demonstrates how to initialize `MyProperty` to prevent this issue.