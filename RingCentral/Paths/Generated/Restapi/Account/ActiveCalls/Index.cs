using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.ActiveCalls
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/active-calls";
        }

        public async Task<RingCentral.ActiveCallsResponse> Get(ListCompanyActiveCallsParameters queryParams = null)
        {
            return await rc.Get<RingCentral.ActiveCallsResponse>(this.Path(), queryParams);
        }

        public async Task<RingCentral.ActiveCallsResponse> Get(object queryParams)
        {
            return await rc.Get<RingCentral.ActiveCallsResponse>(this.Path(), queryParams);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.ActiveCalls.Index ActiveCalls()
        {
            return new Restapi.Account.ActiveCalls.Index(this);
        }
    }
}