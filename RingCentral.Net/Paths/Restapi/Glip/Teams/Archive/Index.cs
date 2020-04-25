using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Glip.Teams.Archive
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Teams.Index parent;

        public Index(Restapi.Glip.Teams.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/archive";
        }

        /// <summary>
        /// Operation: Archive Team
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/teams/{chatId}/archive
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<string> Post(CancellationToken? cancellationToken = null)
        {
            return await rc.Post<string>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Teams
{
    public partial class Index
    {
        public Restapi.Glip.Teams.Archive.Index Archive()
        {
            return new Restapi.Glip.Teams.Archive.Index(this);
        }
    }
}