using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui.Library.Shared.Services
{
    public class TubeService : RestServiceBase
    {
        public TubeService(HttpClient httpClient, IBarrel barrel, IConnectivity connectivity) 
            : base(httpClient, barrel, connectivity)
        {

        }
    }
}
