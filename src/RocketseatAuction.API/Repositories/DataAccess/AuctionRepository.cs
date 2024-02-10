using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories.DataAccess
{ 
    // A class AuctionRepostitory precisa de um interface para que ser
    public class AuctionRepository : IAuctionRepository
    {
        private readonly RocketseatAuctionDbContext _dbContext;
        // Criando um injeção de dependência de RocketseatAuctionDbContext que sera utilizado pelo serviço criado.
        public AuctionRepository(RocketseatAuctionDbContext dbContext) => _dbContext = dbContext;


        public Auction? GetCurrent()
        {
            return _dbContext.Auctions.Include(a => a.Items)
                                  .First();
        }
        
    }
}
