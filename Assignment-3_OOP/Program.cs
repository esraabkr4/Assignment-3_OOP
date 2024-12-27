using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;

namespace Assignment_3_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*************************** Part 01 ************************************/
            #region Q1
            ////Question 1:
            ////What is the primary purpose of an interface in C#?
            ////a) To provide a way to implement multiple inheritance
            ////b) To define a blueprint for a class
            ////c) To declare abstract methods and properties
            ////d) To create instances of objects

            //Correct Answer=> b) To define a blueprint for a class
            #endregion

            #region Q2
            ////Question 2:
            ////Which of the following is NOT a valid access modifier for interface members in C#?
            ////a) private
            ////b) protected
            ////c) internal
            ////d) public

            //Correct Answer=> a) private
            #endregion

            #region Q3
            ////Question 3:
            ////Can an interface contain fields in C#?
            ////a) Yes
            ////b) No
            ////c) Only if they are static
            ////d) Only if they are readonly

            //Correct Answer=> b) No
            #endregion

            #region Q4
            ////Question 4:
            ////In C#, can an interface inherit from another interface?
            ////a) No, interfaces cannot inherit from each other
            ////b) Yes, interfaces can inherit from multiple interfaces
            ////c) Yes, but only if they have the same methods
            ////d) Only if the interfaces are in the same namespace

            //Correct Answer=> b) Yes, interfaces can inherit from multiple interfaces
            #endregion

            #region Q5
            ////Question 5:
            ////Which keyword is used to implement an interface in a class in C#?
            ////a) inherit
            ////b) use
            ////c) extends
            ////d) implements

            //Correct Answer=> d) implements
            #endregion

            #region Q6
            ////Question 6:
            ////Can an interface contain static methods in C#?
            ////a) Yes
            ////b) No
            ////c) Only if the interface is sealed
            ////d) Only if the methods are private

            //Correct Answer=> b) No
            #endregion

            #region Q7
            ////Question 7:
            ////In C#, can an interface have explicit access modifiers for its members?
            ////a) Yes, for all members
            ////b) No, all members are implicitly public
            ////c) Yes, but only for abstract members
            ////d) Only if the interface is sealed

            //Correct Answer=> b) No, all members are implicitly public
            #endregion

            #region Q8
            ////Question 8:
            ////What is the purpose of an explicit interface implementation in C#?
            ////a) To hide the interface members from outside access
            ////b) To provide a clear separation between interface and class members
            ////c) To allow multiple classes to implement the same interface
            ////d) To speed up method resolution

            //Correct Answer=> a) To hide the interface members from outside access
            #endregion

            #region Q9
            ////Question 9:
            ////In C#, can an interface have a constructor?
            ////a) Yes, but it must be private
            ////b) No, interfaces cannot have constructors
            ////c) Yes, but only if the interface is sealed
            ////d) Only if the constructor is static

            //Correct Answer=> b) No, interfaces cannot have constructors
            #endregion

            #region Q10
            ////Question 10:
            ////How can a C# class implement multiple interfaces?
            ////a) By using the "implements" keyword
            ////b) By using the "extends" keyword
            ////c) By separating interface names with commas
            ////d) A class cannot implement multiple interfaces

            //Correct Answer=> c) By separating interface names with commas
            #endregion

            /********************************Part 02*************************************/

            #region Part02
            ////Question 01:
            ////Define an interface named IShape with a property Area and a method 
            ////DisplayShapeInfo.Create two interfaces, ICircle and IRectangle, 
            ////that inherit from IShape.Implement these interfaces in classes 
            ////Circle and Rectangle. Test your implementation by creating instances 
            ////of both classes and displaying their shape information.

            Circle circle = new Circle();
            circle.Area = 50;
            circle.DisplayShapeInfo();

            Rectangle rectangle = new Rectangle();
            rectangle.Area = 80;
            rectangle.DisplayShapeInfo();
            #endregion
        }
    }
}
