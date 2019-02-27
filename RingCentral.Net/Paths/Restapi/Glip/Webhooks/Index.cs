using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Webhooks
{
    public partial class Index
    {
        public RestClient rc;
        public string webhookId;
        public Restapi.Glip.Index parent;

        public Index(Restapi.Glip.Index parent, string webhookId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.webhookId = webhookId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && webhookId != null)
            {
                return $"{parent.Path()}/webhooks/{webhookId}";
            }

            return $"{parent.Path()}/webhooks";
        }

        // Operation: listGlipWebhooks
        // Http Get /restapi/v1.0/glip/webhooks
        public async Task<RingCentral.GlipWebhookList> List()
        {
            return await rc.Get<RingCentral.GlipWebhookList>(this.Path(false));
        }

        // Operation: loadGlipWebhook
        // Http Get /restapi/v1.0/glip/webhooks/{webhookId}
        public async Task<RingCentral.GlipWebhookList> Get()
        {
            if (this.webhookId == null)
            {
                throw new System.ArgumentNullException("webhookId");
            }

            return await rc.Get<RingCentral.GlipWebhookList>(this.Path());
        }

        // Operation: deleteGlipWebhook
        // Http Delete /restapi/v1.0/glip/webhooks/{webhookId}
        public async Task<string> Delete()
        {
            if (this.webhookId == null)
            {
                throw new System.ArgumentNullException("webhookId");
            }

            return await rc.Delete<string>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Webhooks.Index Webhooks(string webhookId = null)
        {
            return new Restapi.Glip.Webhooks.Index(this, webhookId);
        }
    }
}