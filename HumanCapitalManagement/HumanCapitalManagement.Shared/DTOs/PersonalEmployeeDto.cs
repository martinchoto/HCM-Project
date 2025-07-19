namespace HumanCapitalManagement.Shared.DTOs
{
	public class PersonalEmployeeDto
	{
		public int Id { get;  set; }
		public object FullName { get; set; }
		public object Email { get;  set; }
		public string Department { get;  set; }
		public decimal Salary { get;  set; }
	}
}
