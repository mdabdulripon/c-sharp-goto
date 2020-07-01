# Collections: Array
### What is a collection?
- A collection is a class that provides in-memory management of a group of items. A collection can be a simple type or complex type.

**Many kinds of collections available in c sharp.**

-[x] List: A list allows us to manage a group of things.
    - Retrieve an element by an index number.
    - Index numbers are zero-based.

-[x] Dictionary: A dictionary allows us to manage a group of things with a unique key.
    - Retrieve an element with the key.

- [x] Array: An Array is a fixed size list of elements that can be accessed using a positional index number. An array is a Reference type.


-[x] Best Practice of when to use an Array:
    - Consider using an array, when the size of a list can be determined at the design time.
    - Avoid using an array, when the size of a list is not known.

-[x] Array Initialization Best Practice: 
    - Use collection initializers, it provides a much cleaner syntax for declaring and populating an array. 
    - Avoid manually populating an array.


### When is it appropriate to use an array?
 - When working with a list whose length is defined at the design time because arrays are fixed length.
 - When multiple dimensions are needed.
 - To squeeze out a bit more performance with large sets.


### What is the difference between foreach and for loops?
 - foreach provides a simple syntax for iterating all elements in an array.
 - for provides a more complex but flexible syntax for iterating all or any subset of elements in an array.
    - Plus the iterated elements are updateable.

### Notes: 
    - The default value for a string is null.
    - The default value for a int is 0.
    - Any variable declared with the var keyword is known as an implicit type.
