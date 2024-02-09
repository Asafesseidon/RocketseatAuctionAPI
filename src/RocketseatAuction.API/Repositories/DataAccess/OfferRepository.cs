using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories.DataAccess;

public class OfferRepository : IOfferRepository
{
    private readonly RocketseatAuctionsDBContext _dBContext;

    public OfferRepository(RocketseatAuctionsDBContext dBContext) => _dBContext = dBContext;
 
    public void Add(Offer offer)
    {
        _dBContext.Offers.Add(offer);

        _dBContext.SaveChanges();

    }
}
