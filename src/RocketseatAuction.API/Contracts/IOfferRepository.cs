using RocketseatAuction.API.Communication.Request;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Contracts
{
    public interface IOfferRepository
    {
        void Add(Offer offer);
    }
}
