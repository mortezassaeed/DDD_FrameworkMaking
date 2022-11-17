using ApplicationAuctionMangment.Contrancts;
using Framework.Application;
using Microsoft.AspNetCore.Mvc;

namespace AuctionManagment.RestApi.Controllers;
public class AuctionController : Controller
{
    private readonly ICommandBus _bus;

    public AuctionController(ICommandBus bus)
    {
        _bus = bus;
    }
    [HttpPost]
    public IActionResult Post(OpenAuctionCommand request)
    {
        _bus.Dispatch(request);
        return Ok();
    }

}
