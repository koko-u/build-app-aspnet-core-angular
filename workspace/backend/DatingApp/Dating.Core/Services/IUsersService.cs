using Dating.UI;
using Dating.UI.Responses;

namespace Dating.Core.Services;

public interface IUsersService
{
    Task<ResponseData<User>> GetSingleUserAsync(Guid id);
    Task<ResponseData<IEnumerable<User>>> GetUsersAsync();
}
