# Generics

### What are Generics?
- A technique that allows you to write a class or method that can work with any data type.

### What are the benefits of Generics?
- With generics, we can write reuseable code that is type-safe and can work with any data type.

### What is a generics type parameter?
A placeholder for a specific type. for example:
```
	public class OperatorClass<T>
	public class OperatorClass<Tresult, Tmessage>
```
### Where is a generic type parameter define? 
- As part of a class signature.
```
	public class OperatorClass<T>
```
- As per of a method signature
```
	public T RetrieveValue<t>(string sql, T defaultValue)
```

### In this example how do you define the actual type for T?
```public class OprationaResult<T>```
- The type is defined when calling the class constructor. For Example:
```
	var operatorResult = new OperatorResult<decimal>(); 
	In this case the actual type is decimal.
	
	var operatorResult = new OperatorResult<bool>(); 
	In this case the actual type is boolean
```
### What is the purpose of a generic constrains?
- To limit the types accepted for a generic type parameter.
