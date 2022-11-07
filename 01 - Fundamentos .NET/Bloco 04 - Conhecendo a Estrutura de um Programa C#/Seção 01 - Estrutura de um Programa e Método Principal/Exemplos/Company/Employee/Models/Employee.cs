namespace Individual.Models
{
	public class Employee
	{
		public string? name;
		public double grossSalary;
		public double tax;

		public double NetSalary()
		{
				double netSalary = grossSalary - tax;
				return netSalary;
		}

		public void IncreaseSalary(double percentage)
		{
				double newSalary = grossSalary * ((percentage / 100) + 1);
				grossSalary = newSalary;
		}
	}
}
