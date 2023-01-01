using System;
using System.Collections;
using Collections.CustomEnumerators;

namespace Collections
{
	public class Organization : IEnumerable<Employee>
	{
        private List<Employee> employees = new List<Employee>();

		public Organization()
		{
		}

        public int Count {
            get
            {
                return employees.Count;
            }
        }

        public Employee this[int index]
        {
            get
            {
               return employees[index];
            }
        }

        public void Add(Employee employee)
        {
            employees.Add(employee);
        }

        

        IEnumerator<Employee> IEnumerable<Employee>.GetEnumerator()
        {
            return new OrganizationEnumarator(this);
        }

        public IEnumerator GetEnumerator()
        {
            return new OrganizationEnumarator(this);
        }
    }
}

