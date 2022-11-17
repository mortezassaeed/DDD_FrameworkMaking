using Framework.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationAuctionMangment.Contrancts;

public class OpenAuctionCommand : ICommand
{
    public string Product { get; set; }
    public int StartPrice { get; set; }
    public DateTime EndDateTime { get; set; }

}

