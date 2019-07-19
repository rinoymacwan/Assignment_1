using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

             

            Console.WriteLine("Enter Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Deptartment:");
            string dept = Console.ReadLine();

            Employee emp = new Employee(id, name, dept);
            emp.functionCalled = new FunctionCalledDelegate(onFunctionCall);

            Console.WriteLine("ID: " + emp.GetId());
            Console.WriteLine("Name: " + emp.GetName());
            Console.WriteLine("Department: " + emp.GetDepartmentName());

            Console.WriteLine("***Update Calls***");
            emp.Update(6);//calls first method
            emp.Update("NewName");//calls second method
            emp.Update("NewDeptName",1);//calls third method, the integer '1' can be replaced with any integer as it is not used

            Console.WriteLine("ID: " + emp.GetId());
            Console.WriteLine("Name: " + emp.GetName());
            Console.WriteLine("Department: " + emp.GetDepartmentName());

            Console.ReadKey();
        }

        static void onFunctionCall(string x)
        {
            Console.WriteLine(x+" called!");
        }
    }
}
