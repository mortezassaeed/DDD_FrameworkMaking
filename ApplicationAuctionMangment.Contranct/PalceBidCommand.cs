using Framework.Application;

namespace ApplicationAuctionMangment.Contrancts;

public class PalceBidCommand : ICommand {

    public long AuctionId { get; set; }
    public long Amount { get; set; }
    public long BidderId { get; set; }
}

