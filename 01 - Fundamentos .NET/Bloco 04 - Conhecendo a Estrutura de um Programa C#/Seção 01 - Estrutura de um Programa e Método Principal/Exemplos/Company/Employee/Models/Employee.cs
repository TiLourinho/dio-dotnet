namespace Individual.Models
{
	/// <summary>
  /// Employee represents a worker
  /// </summary>
	public class Employee
	{
		public string? name;
		public double grossSalary;
		public double tax;

		/// <summary>
    /// Returns the salary real value
    /// </summary>
		public double NetSalary()
		{
				double netSalary = grossSalary - tax;
				return netSalary;
		}

		/// <summary>
    /// Increases salary based on a percentage
    /// </summary>
		public void IncreaseSalary(double percentage)
		{
				double newSalary = grossSalary * ((percentage / 100) + 1);
				grossSalary = newSalary;
		}
	}
}
