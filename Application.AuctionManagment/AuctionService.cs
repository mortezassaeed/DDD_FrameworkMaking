using ApplicationAuctionMangment.Contrancts;
using Framework.Application;

namespace Application.AuctionManagment;

public class AuctionService : ICommandHandler<PalceBidCommand>, ICommandHandler<OpenAuctionCommand>
{
    public Task Handle(OpenAuctionCommand command)
    {
        throw new NotImplementedException();
    }

    public Task Handle(PalceBidCommand command)
    {
        throw new NotImplementedException();
    }
}


