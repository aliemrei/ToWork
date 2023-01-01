using System;
namespace Collections.CustomComparers
{
	public class EmployeeComparer : IComparer<Employee>
	{
		public EmployeeComparer()
		{
		}

        public int Compare(Employee? x, Employee? y)
        {
            return x.Job.CompareTo(y.Job);
        }
    }
}

