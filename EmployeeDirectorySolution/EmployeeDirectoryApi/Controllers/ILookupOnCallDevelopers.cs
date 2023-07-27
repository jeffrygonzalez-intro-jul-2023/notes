using EmployeeDirectoryApi.Model;

namespace EmployeeDirectoryApi.Controllers;

public interface ILookupOnCallDevelopers
{
    Task<OnCallDeveloperResponseModel> FindCurrentDeveloperAsync();
}