using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using System.Threading.Channels;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_NET_12_OOP06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions

                //Q1: What is abstraction in OOP? How is it different from encapsulation?

                //Abstraction in OOP

                //Abstraction is the process of exposing only the essential features of an object while hiding the internal implementation details.

                //It answers the question:

                //“What can this object do?” without explaining how it does it.

                //Abstraction focuses on design and behavior, not implementation.

                //Encapsulation

                //Encapsulation is the mechanism of hiding internal data and controlling access to it using access modifiers like private, protected, and public.

                //It protects the internal state of the object from direct access.

                //Key Difference (as explained in the presentation)

                //Abstraction decides WHAT to show.

                //Encapsulation decides HOW to protect what is hidden.

                //Real-world example

                //Consider a Car:

                //Abstraction: The driver uses the steering wheel, pedals, and gear to drive the car without knowing how the engine or transmission works.

                //Encapsulation: The engine and internal components are hidden inside the car and cannot be accessed directly by the driver.



                //  Q2 : What is the difference between an abstract class and an interface? Give at least four differences.When would you choose one over the other?

                //      Difference Between Abstract Class and Interface

                //1:Purpose

                //An abstract class provides a base for classes that share common behavior.

                //An interface defines a contract that classes must follow.

                //2:Implementation

                //Abstract classes can contain abstract methods and implemented methods.

                //Interfaces contain method definitions that must be implemented by classes.

                //3:Inheritance

                //A class can inherit from only one abstract class.

                //A class can implement multiple interfaces.

                //4:Constructors and Fields

                //Abstract classes can have constructors and fields.

                //Interfaces do not have constructors or instance fields.

                //When to choose one

                //Use an abstract class when classes share common code and behavior.

                //Use an interface when you want multiple unrelated classes to follow the same contract and allow flexible implementations.

                // Q3 : Look at the following code and answer the questions below:

                //    a)

                //    No, you cannot write

                //    Appliance a = new Appliance("LG");


                //        Because Appliance is an abstract class.

                //    Abstract classes cannot be instantiated directly.
                //    They are meant to be used as base classes for derived classes.

                //    b)

                //    The three methods are different because they represent different levels of abstraction.

                //    PowerConsumption()

                //    This is an abstract method.

                //    It has no implementation in the base class.

                //    Every derived class must implement it.

                //    Status()

                //    This is a virtual method.

                //    It has a default implementation in the base class.

                //    Derived classes can override it if they want.

                //    Label()

                //    This is a concrete method.

                //    It already has a full implementation.

                //    All derived classes inherit it without needing to change it.

                //    The designer used these types so that:

                //    Every appliance must define its power consumption.

                //    Appliances may change their status behavior.

                //    The label behavior is shared by all appliances.

                //    c)

                //    If Status() is called on a Toaster object, it will return:

                //    Standby


                //    Because the Toaster class does not override the Status() method, so it uses the default implementation from the Appliance class.



                //    Q4 : Look at the following code and answer the questions below:

                //    a)

                //    A partial class allows a class definition to be split into multiple files.

                //    Developers split a class into multiple files to:

                //    organize large classes

                //    separate features(like logging)

                //    allow multiple developers to work on the same class

                //    b)

                //    A partial method is a method that is declared in one part of a partial class and optionally implemented in another part.

                //    If the OnCalculated() implementation is removed from Calculator.Logging.cs:

                //     The code will still compile.

                //    This is because if a partial method has no implementation, the compiler removes both the declaration and the calls to it during compilation.

                //    c)

                //    An extension method allows developers to add new methods to an existing type without modifying the original class.

                //    Three rules for extension methods

                //    They must be inside a static class.

                //    The method itself must be static.

                //    The first parameter must use the this keyword to specify the type being extended.

                //    Example:

                //    public static string ToCurrency(this double value)

                //    d)

                //    Code:

                //    Calculator calc = new Calculator();
                //        double result = calc.Add(19.5, 0.5);
                //        Console.WriteLine(result.ToCurrency());


                //    Step 1

                //    19.5 + 0.5 = 20


                //    The logging method prints:

                //    Log: result = 20


                //    Step 2

                //    The extension method converts the value to currency format:

                //    $20.00


                //    Final Output

                //    Log: result = 20
                //    $20.00

                

            #endregion
        }
    }
}
