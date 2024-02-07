﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.UseCases.Auctions.GetCurrent;

namespace RocketseatAuction.API.Controllers
{
   
    public class AuctionController : RocketseatAutionBaseController
    {
        [HttpGet]
        [ProducesResponseType(typeof(Auction),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetLeilaoAtual()
        {
            var useCase = new GetCurrentAuctionUseCase();

            var result = useCase.Execute();
            if (result is null) return NoContent();

            return Ok(result);
        }
    }
}
