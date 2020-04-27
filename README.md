# c-sharp-projects


#### See Documentation [cheat sheet #1](https://www.cheatography.com//laurence/cheat-sheets/c/pdf/) and [cheat sheet #2](https://www.thecodingguys.net/resources/cs-cheat-sheet.pdf) [c-sharp and net-informations](http://csharp.net-informations.com/)

#### What is the difference between .NET and ASP.NET?
- The main difference between .NET and ASP .NET is that .NET is a software framework that allows developing, running and executing applications while ASP .NET is a web framework which is a part of .NET framework that is used to build dynamic websites, web applications, and web services.

#### What are Difference Between ASP.NET VS ASP.NET Core?
| ASP.NET                   | ASP.NET Core                |
|-------------------------- |---------------------------  |
| ASP.NET is only for Windows	| ASP.NET Core is for cross-platform (Windows, Mac and Linux)     |
| ASP.NET Supports Web Form, ASP.NET MVC and ASP.NET Web API.	|ASP.NET Core does not support Web Form. It supports MVC, Web API and ASP.NET Web pages originally added in .NET Core 2.0.|

#### What are the fundamental Object Oriented Programing concepts?
- The four fundamental concepts of Object Oriented Programming are:
   - [Encapsulation:](http://net-informations.com/faq/oops/encapsulation.htm)
      - The encapsulation hides the property and methods from the users or other classes.
      - The encapsulation is implemented by using access specifiers and it defines the scope and visibility of a class member.
   - Abstraction – It is a process of identifying the critical behavior and data of an object and eliminating the irrelevant details.
   - Inheritance – It is the ability to create new classes from another class. It is done by accessing, modifying and extending the behavior of objects in the parent class.
   - Polymorphism – The name means, one name, many forms. It is achieved by having multiple methods with the same name but different implementations.

- [x] ```static```: static methods means you can call this methods before instantiating the class.
- [x] ```void```: this methods does not return any data.
- [x] ```Main```: Main method is the entry point of the c sharp program.
- [x] ```string[] args```: is used for command line arguments in C sharp.

### Data Types:
**The variables in C sharp, are categorized in three types−**
- [x] Value Types
- [x] Reference Types
- [x] Pointer Types

### [Value Types](http://net-informations.com/faq/general/valuetype-referencetype.htm)
- Value Type holds the data within its own memory allocation.
- Value Type variables are stored in the stack.

### [Reference Types](http://net-informations.com/faq/general/valuetype-referencetype.htm)
- Reference Type contains a pointer to another memory location that holds the real data.
- Reference Type variables are stored in the heap

### Pointer Types
- The Pointer Data Types will contain a memory address of variable value.
   - To get the pointer details we have a two symbols ampersand (&) and asterisk (*)
```
   // Declaring the pointer data type
   int* a;
```
#### Data type diagram:
![alt text](https://www.c-sharpcorner.com/UploadFile/BlogImages/11292012154826PM/CsharpDataTypesChart.png)

### [What is Stack and Heap?](http://net-informations.com/faq/net/stack-heap.htm)
- Stack is used for static memory allocation and Heap for dynamic memory allocation, both stored in the computer's RAM.

#### How to get the exact size of a type or a variable.
```
   // to get exact size of a data type
   Console.WriteLine($"Size of int: {sizeof(int)}");
```
#### Dynamic Type
*You can store any type of value in the dynamic data type variable. Type checking for these types of variables takes place at run-time.*
```
   dynamic d = 20;
```

#### Type conversion
*Type conversion is converting one type of data to another type. It is also known as Type Casting. In C#, two type of conversion available-*
- [x] Implicit type conversion:
- [x] Explicit type conversion:

#### what is boxing and unboxing?
- Boxing:
- Unboxing:

#### What is Access Specifiers
*The Access specifier determines the visibility of the variables or the methods from another class.*
- [x] ```public```: Accessible by any other code in the same assembly or another assembly that references it.
- [x] ```private```: Only accessible by code in the same class or struct.
- [x] ```protected``` Only accessible by code in the same class or struct, or in a derived class.
- [x] ```internal``` Accessible by any code in the same assembly, but not from another assembly.
- [x] ```protected internal``` Accessible by any code in the same assembly, or by any derived class in another assembly

#### Protected Internal Vs. Private Protected
| Protected Internal                   | Private Protected           |
| ----------------------               | --------------------------  |
| accessible only in the child classes | is not accessible.          |

> #### Reference type
> Objects are reference type that means they hold the references to their data not the data itself.

> #### Value Reference
> Integers are value type that means they hold there data directly.

#### What is Enum?
- Enum is a value type data type. The enum is used to declare a list of named integer constants.
  - The enum is a set of named constant.
  - The value of enum constants starts from 0. Enum can have value of any valid numeric type.
  - String enum is not supported in C#.
  - Use of enum makes code more readable and manageable.

#### What is Namespaces?
- Namespaces are heavily used in C Sharp program mainly for two reasons.
   - First, it is organize the multiple classes.
   - Second, it will reduce the code redundancy.

#### what is Constructors
- A constructor is a member function in a class that has the same name as its class.
- The constructor is automatically invoked whenever an object class is created.
- It constructs the values of data members while initializing the class.


#### Convert string to an integer
```
    string number = "32";
    int num = int.Parse(number);
```

### Array
```
// Single-Dimensional Arrays
// Declaring and Initializing an array with size
int[] array = new int[5];

// Declaring and assigning elements at the same time
int[] array2 = new int[5] {1,2,3,4,5};

// Declaring and assigning elements at the same time without size
int[] array3 = new int[] { 1, 2, 3, 4, 5 };  

// Another way to Declaring and assigning elements at the same time without size
int[] array4 = { 1, 2, 3, 4, 5 };

// Declare an array without initialization
int[] array5;
array5 = new int[]{ 1, 2, 3, 4, 5 };
```
### Array Types:
- [x] Single-Dimensional Arrays
- [x] Multi-Dimensional Arrays
- [x] Jagged Arrays