//Daniel Frykman .NET23
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;

namespace Labb8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create objects
            Employee emp1 = new(1, "Ape", 'M', 23000);
            Employee emp2 = new(2, "Gorilla", 'F', 21000);
            Employee emp3 = new(3, "Macaque", 'F', 28000);
            Employee emp4 = new(4, "Orangutan", 'M', 19000);
            Employee emp5 = new(5, "Silverback", 'M', 50000);

            //create a list and add all objects. create a stack and add the list to it
            List<Employee> empList = new() {emp1, emp2, emp3, emp4, emp5};
            Stack<Employee> empStack = new(empList);

            //run methods
            Methods.OutputStack(empStack);
            Methods.PopStack(empStack);
            
            //refill stack, I spent many hours googling and testing trying to find a "better" way
            //of refilling the stack. maybe I'll figure it out later
            empStack.Push(emp1);
            empStack.Push(emp2);
            empStack.Push(emp3);
            empStack.Push(emp4);
            empStack.Push(emp5);
            
            //more methods
            Methods.OutputStack(empStack);
            Methods.PeekStack(empStack);
            Methods.PeekStack(empStack);
            Methods.IsInStack(empStack, emp3);

            Methods.IsInList(empList, emp2);
            Methods.FindFirstMaleInList(empList);
            Methods.FindAllMalesInList(empList);
        }
    }
}