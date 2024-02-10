using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Filters;
using RocketseatAuction.API.UseCases.Auctions.GetCurrent;

namespace RocketseatAuction.API.Controllers
{
    [ServiceFilter(typeof(AuthenticationUserAttribute))]
    public class AuctionController : RocketseatAutionBaseController
    {
        [HttpGet]
        [ProducesResponseType(typeof(Auction),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetLeilaoAtual([FromServices] GetCurrentAuctionUseCase useCase)
        {
           

            var result = useCase.Execute();
            if (result is null) return NoContent();

            return Ok(result);
        }
    }
}
