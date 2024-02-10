using RocketseatAuction.API.Communication.Request;
using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Services;

namespace RocketseatAuction.API.Repositories.DataAccess
{
    public class OfferRepository : IOfferRepository
    {
        private readonly RocketseatAuctionDbContext _dbContext;

       

        public OfferRepository(RocketseatAuctionDbContext dbContext, LoggedUser loggerUser)
        {
            _dbContext = dbContext;           
        }

        public void Add(Offer offer)
        {
            _dbContext.Offers.Add(offer);
            _dbContext.SaveChanges();
        }
    }
}
