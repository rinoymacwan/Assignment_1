using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Employee
    {
        private int Id;
        private string Name, DepartmentName;
        public Employee(int Id, string Name, string DepartmentName)
        {
            this.Id = Id;
            this.Name = Name;
            this.DepartmentName = DepartmentName;
        }
        public string GetId()
        {
            functionCalled("GetID");
            return Id.ToString();
        }
        public string GetName()
        {
            functionCalled("GetName");
            return Name;
        }
        public string GetDepartmentName()
        {
            functionCalled("GetDepartmentName");
            return DepartmentName;
        }

        /*
        I was not sure how to interpret this requirement "Create 3 overloaded methods 
        which allows updating any of the Employee property (Id, Name, DepartmentName)" because the updation of both 
        Name and DepartmentName just requires one string. I added an int flag to differentiate the two.
        */
        public void Update(int id)
        {
            this.Id = id;
        }

        public void Update(string name)
        {
            this.Name = name;
        }

        public void Update(string dept, int flag)
        {
            this.DepartmentName = dept;
        }

        public FunctionCalledDelegate functionCalled;
    }
}
