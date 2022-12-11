using AutoMapper;
using Dating.Db.Data;
using Dating.UI;
using Dating.UI.Responses;
using Microsoft.EntityFrameworkCore;

namespace Dating.Core.Services;

public class UsersService : IUsersService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    public UsersService(AppDbContext dbContext, IMapper mapper)
    {
        _mapper = mapper;
        _dbContext = dbContext;
    }

    public async Task<ResponseData<IEnumerable<User>>> GetUsersAsync()
    {
        var users = await _dbContext.Users.ToListAsync();
        return ResponseData.Ok(_mapper.Map<IEnumerable<User>>(users));
    }

    public async Task<ResponseData<User>> GetSingleUserAsync(Guid id)
    {
        var user = await _dbContext.Users.SingleOrDefaultAsync(user => user.Id == id);
        if (user == null)
        {
            return ResponseData.Err<User>($"user with id {id} is not found.", () => new());
        }

        return ResponseData.Ok(_mapper.Map<User>(user));
    }

}
