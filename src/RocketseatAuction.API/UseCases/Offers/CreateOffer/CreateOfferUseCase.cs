using RocketseatAuction.API.Communication.Request;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Repositories;
using RocketseatAuction.API.Services;

namespace RocketseatAuction.API.UseCases.Offers.CreateOffer
{
    public class CreateOfferUseCase
    {
        private readonly LoggedUser _loggerUser;

        public CreateOfferUseCase(LoggedUser loggedUser) => _loggerUser = loggedUser;

        public int Execute(int itemId, RequestCreateOfferJson request)
        {
            var repository = new RocketseatAuctionDbContext();

            var loggedUser = _loggerUser.User();

            var offer = new Offer
            {
                CreatedOn = DateTime.Now,
                ItemId = itemId,
                Price = request.Price,
                UserId = loggedUser.Id,
            };

            repository.Offers.Add(offer);
            repository.SaveChanges();

            return offer.Id;
        }
    }
}
