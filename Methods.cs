using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{
    internal class Methods
    {
        //pop the stack using a loop
        public static void PopStack(Stack<Employee> stackName)
        {
            Console.WriteLine("Stack.Pop()");
            while (stackName.Count > 0)
            {
                Employee popStack = stackName.Pop();
                Console.WriteLine($"{popStack.Id} - {popStack.Name} - {popStack.Gender} - {popStack.Salary}" +
                                  $"\nItems left in stack: {stackName.Count}");
            }
            Console.WriteLine();
        }

        //output contents of stack
        public static void OutputStack(Stack<Employee> stackName)
        {
            Console.WriteLine("List stack");
            foreach (var employee in stackName)
            {
                Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}" +
                                  $"\nItems left in stack: {stackName.Count}");
            }
            Console.WriteLine();
        }

        //take a peek
        public static void PeekStack(Stack<Employee> stackName)
        {
            Employee empPeek = stackName.Peek();
            Console.WriteLine($"Stack.Peek()\n{empPeek.Id} - {empPeek.Name} - {empPeek.Gender} - {empPeek.Salary}" +
                              $"\nItems left in stack: {stackName.Count}\n");
        }

        //check if an employee is in the stack
        public static void IsInStack(Stack<Employee> stackName, Employee name)
        {
            Console.WriteLine("Stack.Contains()");
            Console.WriteLine(stackName.Contains(name) ? $"{name.Name} is in stack\n" : $"{name.Name} is not in stack\n");
        }
        
        //check if an employee is in the list
        public static void IsInList(List<Employee> listName, Employee name)
        {
            Console.WriteLine("List.Contains()");
            Console.WriteLine(listName.Contains(name) ? $"{name.Name} is in list\n" : $"{name.Name} is not in list\n");
        }

        //find the first male in the list
        public static void FindFirstMaleInList(List<Employee> listName)
        {
            Employee empFind = listName.Find(x => x.Gender == 'M');
            Console.WriteLine($"List.Find() Gender 'M'ale\n{empFind.Id} - {empFind.Name} - {empFind.Gender} - {empFind.Salary}\n");
        }

        //find all the males in the list
        public static void FindAllMalesInList(List<Employee> listName)
        {
            List<Employee> empFindAll = listName.FindAll(x => x.Gender == 'M');
            Console.WriteLine("List.FindAll() Gender 'M'ale");
            foreach (var emp in empFindAll)
            {
                Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Gender} - {emp.Salary}");
            }
            Console.WriteLine();
        }
    }
}
