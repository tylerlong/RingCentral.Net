using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Glip.Groups.BulkAssign
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Groups.Index parent;

        public Index(Restapi.Glip.Groups.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/bulk-assign";
        }

        /// <summary>
        /// Operation: Edit Group Members
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/groups/{groupId}/bulk-assign
        /// Rate Limit Group: Medium
        /// App Permission Required: Glip
        /// User Permission Required: Glip
        /// </summary>
        public async Task<RingCentral.GlipGroupInfo> Post(RingCentral.EditGroupRequest editGroupRequest,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.GlipGroupInfo>(this.Path(), editGroupRequest, null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Groups
{
    public partial class Index
    {
        public Restapi.Glip.Groups.BulkAssign.Index BulkAssign()
        {
            return new Restapi.Glip.Groups.BulkAssign.Index(this);
        }
    }
}