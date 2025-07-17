using System.ComponentModel.DataAnnotations;

namespace HumanCapitalManagement.Data
{
	public class Department
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; } = null!;
		public ICollection<Employee> Employees { get; set; } = new List<Employee>();
		
	}
}
