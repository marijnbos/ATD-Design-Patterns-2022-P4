# Sudoku Puzzle Solver

This project is a versatile and scalable Sudoku puzzle solver that can handle a variety of Sudoku types such as 4x4, 6x6, 9x9, Samurai, and Jigsaw. It uses a number of design patterns and maintains a high standard of code quality with unit test coverage of over 70%.

## Design Patterns

The design of this project follows well-established design patterns. They are grouped into three categories: Creational, Structural, and Behavioural patterns. Below is the explanation and links to additional resources for each of them.

### Creational Patterns

- **Low binding factory**: This project uses the factory method pattern to manage the creation of different types of Sudoku puzzles. This pattern provides an interface for creating objects in a super class, but allows subclasses to alter the type of objects that will be created. This adds a layer of abstraction and loose coupling which makes the program more flexible and extendable. More information can be found [here](https://refactoring.guru/design-patterns/factory-method).

- **Builder**: The builder pattern is used to construct complex Sudoku puzzles. This pattern allows you to produce different types and representations of an object using the same construction code. It's particularly useful when dealing with complex objects that require a lot of steps to build. More information can be found [here](https://refactoring.guru/design-patterns/builder).

### Structural Patterns

- **Composite**: The composite design pattern is utilized in the project to handle complex and nested Sudoku puzzles like Samurai and Jigsaw. The composite pattern lets you compose objects into tree structures and then work with these structures as if they were individual objects. More information can be found [here](https://refactoring.guru/design-patterns/composite).

- **Adapter**: The adapter pattern is used to allow classes with incompatible interfaces to work together. It wraps the "adaptee" with a new interface so it can be used by the client code.

### Behavioural Patterns

- **Observer**: This pattern is used to establish a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. In the context of this Sudoku solver, it's used to inform other components about the changes in the state of the puzzle. More information can be found [here](https://refactoring.guru/design-patterns/observer).

- **State**: This pattern is used to allow an object to change its behavior when its internal state changes. It helps to ensure that the program behaves correctly as the state of the Sudoku puzzle changes. More information can be found [here](https://refactoring.guru/design-patterns/state).

- **Visitor**: The visitor pattern allows adding new operations to existing object structures without modifying them. It's used to perform operations over the elements of the Sudoku puzzle. More information can be found [here](https://refactoring.guru/design-patterns/visitor).

- **Strategy**: The strategy pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. It lets the algorithm vary independently from clients that use it. In this project, it's used to allow for different solving strategies for the Sudoku puzzles. More information can be found [here](https://refactoring.guru/design-patterns/strategy).

## Unit Test Coverage

We aim to maintain a high standard of code quality and stability. As part of this commitment, we have a target of 70%+ unit test coverage in our codebase. This ensures that most of the code is covered by automated tests, providing a safety net for future development and refactoring.

## Conclusion

With the power of these design patterns and our commitment to code quality, we aim to provide a robust and efficient Sudoku puzzle solver that can tackle various types of Sudoku puzzles. 

---

**Contributor:** OpenAI's ChatGPT
