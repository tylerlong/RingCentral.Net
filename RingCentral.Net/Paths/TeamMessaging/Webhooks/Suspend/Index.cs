using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.Webhooks.Suspend
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

        public string Path()
        {
            return $"{parent.Path()}/suspend";
        }

        /// <summary>
        ///     Suspends a webhook by ID.
        ///     HTTP Method: post
        ///     Endpoint: /team-messaging/{version}/webhooks/{webhookId}/suspend
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.Webhooks
{
    public partial class Index
    {
        public Suspend.Index Suspend()
        {
            return new Suspend.Index(this);
        }
    }
}