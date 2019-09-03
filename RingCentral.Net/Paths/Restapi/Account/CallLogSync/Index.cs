using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CallLogSync
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
            return $"{parent.Path()}/call-log-sync";
        }

        /// <summary>
        /// Operation: Sync Company Call Log
        /// Http Get /restapi/v1.0/account/{accountId}/call-log-sync
        /// </summary>
        public async Task<RingCentral.AccountCallLogSyncResponse> Get(SyncAccountCallLogParameters queryParams = null)
        {
            return await rc.Get<RingCentral.AccountCallLogSyncResponse>(this.Path(), queryParams);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.CallLogSync.Index CallLogSync()
        {
            return new Restapi.Account.CallLogSync.Index(this);
        }
    }
}