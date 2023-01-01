using System;
namespace Collections.CustomComparers
{
	public class EmployeeComparer : IComparer<Employee>
	{
		public EmployeeComparer()
		{
		}

        public int Compare(Employee a, Employee b)
        {
            return a.Job.CompareTo(b.Job);
        }
    }
}

