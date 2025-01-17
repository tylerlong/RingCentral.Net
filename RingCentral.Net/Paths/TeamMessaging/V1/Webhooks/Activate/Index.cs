using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.V1.Webhooks.Activate
{
    public class Index
    {
        public Webhooks.Index parent;
        public RestClient rc;

        public Index(Webhooks.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/activate";
        }

        /// <summary>
        ///     Activates a webhook by ID.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/v1/webhooks/{webhookId}/activate
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), null, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1.Webhooks
{
    public partial class Index
    {
        public Activate.Index Activate()
        {
            return new Activate.Index(this);
        }
    }
}