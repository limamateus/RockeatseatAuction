using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Communication.Request;
using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Repositories;
using RocketseatAuction.API.Services;

namespace RocketseatAuction.API.UseCases.Offers.CreateOffer
{
    public class CreateOfferUseCase
    {
        private readonly IOfferRepository _repository;

        private readonly ILoggedUser _loggerUser;
        public CreateOfferUseCase(IOfferRepository repository, ILoggedUser loggerUser)
        {
            _repository = repository;
            _loggerUser = loggerUser;
        }

        public int Execute(int itemId, RequestCreateOfferJson request)
        {
            var user = _loggerUser.User();
            var offer = new Offer
            {
                CreatedOn = DateTime.Now,
                ItemId = itemId,
                Price = request.Price,
                UserId = user.Id,
            };

            _repository.Add(offer);

            return offer.Id;
        }

    }
}
