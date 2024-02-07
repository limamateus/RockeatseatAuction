using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Communication.Request;
using RocketseatAuction.API.Filters;
using RocketseatAuction.API.UseCases.Offers.CreateOffer;

namespace RocketseatAuction.API.Controllers
{

    [ServiceFilter(typeof(AuthenticationUserAttribute))] // Autenticação apenas para todos endpoint
    public class OfferController : RocketseatAutionBaseController
    {
        
        [HttpPost]
        [Route("{itemId}")]
        //   [ServiceFilter(typeof(AuthenticationUserAttribute))] // Autenticação apenas para esse endpoint
        public IActionResult CreateOffer([FromRoute] int itemId, [FromBody] RequestCreateOfferJson request, [FromServices] CreateOfferUseCase useCase)
        {
           var id = useCase.Execute(itemId, request);
            return Created(string.Empty, id);
        }
    }
}
