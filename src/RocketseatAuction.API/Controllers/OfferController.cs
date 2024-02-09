using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Communications.Requests;
using RocketseatAuction.API.Filters;
using RocketseatAuction.API.UseCases.Offers.CreateOffers;

namespace RocketseatAuction.API.Controllers;

[ServiceFilter(typeof(AuthentificationUserAttribute))]
public class OfferController : RocketseatAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer(
        [FromRoute] int itemId,
        [FromBody] RequestCreateOfferJson request,
        [FromServices] CreateOfferUseCase useCase)
    {
        var id = useCase.Execute(itemId, request);
        
        return Created(string.Empty, id);
    }
}
