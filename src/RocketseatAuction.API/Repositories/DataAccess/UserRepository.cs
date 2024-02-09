using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories.DataAccess;

public class UserRepository : IUserRepository
{
    private readonly RocketseatAuctionsDBContext _dBContext;

    public UserRepository(RocketseatAuctionsDBContext dBContext) => _dBContext = dBContext;

    public bool ExistsUserWithEmail(string email)
    {
        return _dBContext.Users.Any(user => user.Email.Equals(email));
    }

    public bool ExistUserWithEmail(string email)
    {
        throw new NotImplementedException();
    }

    public User GetUserByEmail(string email) => _dBContext.Users.First(user => user.Email.Equals(email));
}
