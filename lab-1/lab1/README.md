# Description of programming principles in code:
1) DRY (Don't Repeat Yourself): Code uses interfaces and shared methods for shared actions.
For example, the Display() method for displaying the currency price is used in the classes [UkrainianHryvnia, Euro, and Dollar](https://github.com/cxsarina/KPZ/blob/614322c9b4da417857dd80161bb757d438fffba1/lab-1/lab1/lab1/Program.cs#L11C1-L58C2),
instead of repeating the code for each class.
2) KISS (Keep It Simple, Stupid): The code has a simple structure and is easy to understand. Each class has a well-defined responsibility, and the methods implement only the necessary functionality.
3) SOLID:
   - Single Responsibility Principle: Each class has one specific responsibility, for example, the [Product class](https://github.com/cxsarina/KPZ/blob/614322c9b4da417857dd80161bb757d438fffba1/lab-1/lab1/lab1/Program.cs#L59C1-L85C2) is responsible for working with the product, and the [Warehouse](https://github.com/cxsarina/KPZ/blob/614322c9b4da417857dd80161bb757d438fffba1/lab-1/lab1/lab1/Program.cs#L86C1-L102C2) for working with the warehouse.
   - Open/Closed Principle: The code is ready to be extended by new classes (for example, [a new currency](https://github.com/cxsarina/KPZ/blob/614322c9b4da417857dd80161bb757d438fffba1/lab-1/lab1/lab1/Program.cs#L4C1-L10C2)), but closed to changes in already existing classes.
   - Liskov Substitution Principle: Objects can be replaced by their subtypes without changing the desired functionality. For example, [classes UkrainianHryvnia, Euro](https://github.com/cxsarina/KPZ/blob/614322c9b4da417857dd80161bb757d438fffba1/lab-1/lab1/lab1/Program.cs#L11C1-L58C2), and Dollar implement the [IMoney](https://github.com/cxsarina/KPZ/blob/614322c9b4da417857dd80161bb757d438fffba1/lab-1/lab1/lab1/Program.cs#L4C1-L10C2) interface and can be used anywhere an object of type IMoney is expected.
4) YAGNI (You Ain't Gonna Need It): The code contains only the functionality that is needed at the moment. For example, product price reduction is implemented in the [Product class](https://github.com/cxsarina/KPZ/blob/614322c9b4da417857dd80161bb757d438fffba1/lab-1/lab1/lab1/Program.cs#L59C1-L85C2), but no other unnecessary functionality is provided.
5) Program to Interfaces not Implementations: Code interacts with objects through interfaces ([IMoney](https://github.com/cxsarina/KPZ/blob/614322c9b4da417857dd80161bb757d438fffba1/lab-1/lab1/lab1/Program.cs#L4C1-L10C2), [Product](https://github.com/cxsarina/KPZ/blob/614322c9b4da417857dd80161bb757d438fffba1/lab-1/lab1/lab1/Program.cs#L59C1-L85C2)), which provides flexibility and ease of change.