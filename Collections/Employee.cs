using System;
namespace Collections
{
	public class Employee : IComparable<Employee>
	{
		public Employee()
		{
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Job { get; set; }
		public double Salary { get; set; }

        public int CompareTo(Employee obj)
        {
			if (this.Id > obj.Id)
				return 1;
			else if (this.Id < obj.Id)
				return -1;

			return 0;
        }
    }
}

