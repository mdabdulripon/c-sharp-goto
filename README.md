# c-sharp-projects

### See the cheat sheet 
- [x] [cheat sheet #1](https://www.cheatography.com//laurence/cheat-sheets/c/pdf/) 
- [x] [cheat sheet #2](https://www.thecodingguys.net/resources/cs-cheat-sheet.pdf)

### See  Documentation
- [x] [Tutlane](https://www.tutlane.com/tutorial/csharp)
- [x] [Net-informations](http://csharp.net-informations.com/)
- [x] [Tutorialsteacher](https://www.tutorialsteacher.com/csharp/csharp-tutorials)

### What is the difference between .NET and ASP.NET?
- The main difference between **.NET** and **ASP .NET** is that - 
   - **.NET** is a *software framework* that allows developing, running and executing application And 
   - **ASP .NET** is a *web framework* which is a part of *.NET* framework that is used to build dynamic websites, web applications, and web services.

### What are Difference Between ASP.NET VS ASP.NET Core?
| ASP.NET                   | ASP.NET Core                |
|-------------------------- |---------------------------  |
| ASP.NET is only for Windows	| ASP.NET Core is for cross-platform (Windows, Mac and Linux)     |
| ASP.NET Supports Web Form, ASP.NET MVC and ASP.NET Web API.	|ASP.NET Core does not support Web Form. It supports MVC, Web API and ASP.NET Web pages originally added in .NET Core 2.0.|

### What are the fundamental pillar Object Oriented Programing concepts?
- The four fundamental concepts of Object Oriented Programming are:
   - [Abstraction:](https://www.javatpoint.com/c-sharp-abstract) Abstraction is the process to hide the internal details and showing the functionality only.
      - Abstraction methods: 
         - The method which is declared abstract keyword and has no body is called abstract method.
         - It can be declared inside the abstract class only.
         - Its implementation must be provided by derived classes.
   - [Encapsulation:](http://net-informations.com/faq/oops/encapsulation.htm)
      - The encapsulation hides the property and methods from the other classes.
      - The encapsulation can be implemented by using access specifiers 
      - It defines the scope and the visibility of the class member.
   - [Inheritance:](https://www.tutlane.com/tutorial/csharp/csharp-inheritance) 
      - It is the ability to create new classes from another class.
   - [Polymorphism:](https://www.tutlane.com/tutorial/csharp/csharp-polymorphism) 
      - The name means, one name, many forms. It is achieved by having multiple methods with the same name but different implementations.

### What is Static modifier?
- The static modifier declares a member, that belongs to the class itself, instead of an object of the class. 

### What is Namespaces?
- Namespaces are heavily used in C Sharp program mainly for two reasons.
   - First, it is organize the multiple classes.
   - Second, it will reduce the code redundancy.

### What is Constructors
- A Constructor is basically a special kind of method or function, that name with the class name, and executed each time an instance of the class is created.
- A Class can have multiple constructor.
- A Constructor with no parameters is called default Constructor.

### What is Access Specifiers
*The Access specifier determines the visibility of the variables or the methods from another class.*
- [x] ```public```: Accessible by any other code in the same assembly or another assembly that references it.
- [x] ```private```: Only accessible by code in the same class or struct.
- [x] ```protected```: Only accessible by code in the same class or struct, or in a derived class.
- [x] ```internal```: Accessible by any code in the same assembly, but not from another assembly.
- [x] ```protected internal```: Accessible by any code in the same assembly, or by any derived class in another assembly

### Data Types:
**The variables in C sharp, are categorized in three types−**
- [Value Types](http://net-informations.com/faq/general/valuetype-referencetype.htm)
   - Value Type holds the data within its own memory allocation.
   - Value Type variables are stored in the stack.
   ```
      var i1;
      i1 = 42;
      int i2 = i1;
      i2 = 2 
      Console.ReadLine(i1) // should be 42.
   ```
- [Reference Types](http://net-informations.com/faq/general/valuetype-referencetype.htm)
   - Reference Type contains a pointer to another memory location that holds the real data.
   - Reference Type variables are stored in the heap
   ```
      var c1 = new Customer();
      c1.FirstName = "Dave";
      c2 = c1;
      c2.FirstName = "Bobby";
      Console.ReadLine(c1.FirstName) // should be Bobby Because the are reference to the same customer.
   ```
- Pointer Types
   - The Pointer Data Types will contain a memory address of variable value.
   - To get the pointer details we have a two symbols ampersand (&) and asterisk (*)
   ```
      // Declaring the pointer data type
      int* a;
   ```
### Data type diagram:
![alt text](https://www.c-sharpcorner.com/UploadFile/BlogImages/11292012154826PM/CsharpDataTypesChart.png)

### [What is Stack and Heap?](http://net-informations.com/faq/net/stack-heap.htm)
- Stack is used for static memory allocation and Heap for dynamic memory allocation, both stored in the computer's RAM.

### How to get the exact size of a type or a variable.
```
   // to get exact size of a data type
   Console.WriteLine($"Size of int: {sizeof(int)}");
```
### Dynamic Type
*You can store any type of value in the dynamic data type variable. Type checking for these types of variables takes place at run-time.*
```
   dynamic d = 20;
```

### Convert string to an integer
```
    string number = "32";
    int num = int.Parse(number);
```

### Array Types:
- There are three type of array is available in c#
   - Single-Dimensional Arrays
   - Multi-Dimensional Arrays
   - Jagged Arrays

### What is Coupling and Decoupling?
- Coupling / Strong Coupling: 
   - A relationship between two entities or class, when they know too much about each other is called strong coupled relationship.
- Decoupling / Loose Coupling: 
   - A relationship between two entities or class, where they know little about each other is called loosely coupled aka decoupled relationship. 
   - Having code that is modularized and decoupled will make your code more understandable, more testable, and more maintainable.

### What is the benefit of Low Coupling and High Cohesion?
- Low Coupling: 
   - When the re is low coupling there is a reduce probability that changes to one class adversely affect other class, making maintenance easier.
   - And low coupling make testing straightforward because the class has minimal dependency on other classes.

- High Cohesion:
   - When there is high cohesion, there is a higher probability that a feature request will affect only a small number of  classes, simplifying maintenance.
   - And high cohesion helps produce a focused, well defined, and complete class, making it easier to understand and test. Classes 


### Type conversion
*Type conversion is converting one type of data to another type. It is also known as Type Casting. In C#, two type of conversion available-*
- Implicit type conversion:
- Explicit type conversion:

### what is boxing and unboxing?
- Boxing:
- Unboxing:

### Protected Internal vs Private Protected
| Protected Internal                   | Private Protected           |
| ----------------------               | --------------------------  |
| accessible only in the child classes | is not accessible.          |

### What is Enum?
- Enum is a value type data type. The enum is used to declare a list of named integer constants.
  - The enum is a set of named constant.
  - The value of enum constants starts from 0. Enum can have value of any valid numeric type.
  - String enum is not supported in C#.
  - Use of enum makes code more readable and manageable.

### [What is generics](https://www.tutorialsteacher.com/csharp/csharp-generics)?

