using HumanCapitalManagement.Shared.DTOs;

namespace HumanCapitalManagement.Services.Interfaces
{
	public interface IEmployeeService
	{
		Task<PersonalEmployeeDto> GetPersonalDataAsync(string id);
	}
}
