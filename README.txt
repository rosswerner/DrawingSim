# DrawingSimulator


## Description

This project is a simple GUI-less library for some simple drawing primitives (widgets):
1) Rectangle
2) Square
3) Ellipse
4) Circle
5) Textbox

The project states the location and size/shape of the widgets.


## Design Decisions
-Single Responsibility Principle
I utilised an abstract base class "Shape" that defines common properties and methods. Each of the widget classes followed the SRP by defining the properties and behavior of their shape, which can then be further abstracted.

-Open/Closed Principle
Each specific widget inherits from this base class (or in the case of Textbox, it inherits from Rectangle) allowing for widget-specific implementations following the OCP to allow new widgets to be added with minimal changes to existing code.

-Liskov Substitution Princple
My implementation is really too simple to adequately show the LSP, but technically all widgets conform to the Shape base class and any code that works with Shape can interact with any widget as demonstrated in the Program.cs file where I utilize List<Shape> to store each widget added to the Drawing Simulator.

-Interface Segragation Principle
There are no methods/properties in Shape that are not applicable to each widget. If additional functionalities need to be added in the future, they can be added in Shape if applicable to all widgets, or introduced through separate abstract classes or interfaces.

-Dependency Inversion Principle
Client code (Program.cs in this case) could depend on the abstract class "Shape" instead of specific widget implementations. This keeps high-level logic decoupled from the details of individual shapes, allowing functions like "WriteProperty" to operate on any shape that inherits from "Shape", ensuring flexibility and adaptability in the design.


## Alternatives
An interface would have been a viable solution, but I would have had to implement all methods and properties, leading to code duplication. This could require modifications/extensions to potentially be completed in multiple locations. 


## Further Work
Right now, we are not exiting gracefully when incorrect values are used (negatives). My next step would be to reach out to the user/product owner/client to determine whether the program should do one of the following:
Write OOB widget value to the console.
Ignore widgets with OOB values.
Write error to a Log file.
Open a MessageBox with an error message. Potentially allow for correcting the value in the window.
Or something else as required/requested by the user/product owner/client.

I would also get requirements and implement them for any other properties. (Values too large, Textbox text length, etc.).