using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Cx.SocialMessaging.V1.Contents
{
    public class Index
    {
        public string contentId;
        public V1.Index parent;
        public RestClient rc;

        public Index(V1.Index parent, string contentId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.contentId = contentId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && contentId != null) return $"{parent.Path()}/contents/{contentId}";
            return $"{parent.Path()}/contents";
        }

        /// <summary>
        ///     List contents by creation date. The default creation order is descending.
        ///     The account context of this request is determined by the RC Account Id associated with the access token provided
        ///     in the Authorization header.
        ///     The query parameters provided shall be considered an AND operation to filter the list.
        ///     A query parameter not specified or a query parameter provided with no value is treated as not required for
        ///     filtering the list.
        ///     HTTP Method: get
        ///     Endpoint: /cx/social-messaging/v1/contents
        ///     Rate Limit Group: Light
        ///     App Permission: SocialMessaging
        /// </summary>
        public async Task<string> List(SocMsgListContentsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<string>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates new content for use in discussions.
        ///     This request is used to reply to already-posted content or to initiate a discussion. If authorized, the
        ///     authenticated user will be used as the content author.
        ///     Content will be created and pushed asynchronously to the channel. When the content is successfully pushed to
        ///     the channel, the Content.Exported event will be reported.
        ///     The account context of this request is determined by the RC Account Id associated with the access token provided
        ///     in the Authorization header.
        ///     Replying to customer content is usually possible unless the channel or conversation is read only. Composing
        ///     content, on the contrary, depends on the channel itself.
        ///     * The channel may not support it (and be purely reactive like Instagram, Messenger, etc.).
        ///     * Some channels (usually public accounts like Twitter or Facebook pages) allow for the publishing of content
        ///     without targeting specific individuals.
        ///     * Some channels (usually non-public media) require specific targeting (phone number for SMS, email address
        ///     for email, customer_id, etc.) to be able to create content. This is channel-specific and detailed under the
        ///     generic parameters.
        ///     HTTP Method: post
        ///     Endpoint: /cx/social-messaging/v1/contents
        ///     Rate Limit Group: Light
        ///     App Permission: SocialMessaging
        /// </summary>
        public async Task<string> Post(CreateContentRequest createContentRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(false), createContentRequest, null, restRequestConfig);
        }

        /// <summary>
        ///     Retrieves the content from the given id.
        ///     HTTP Method: get
        ///     Endpoint: /cx/social-messaging/v1/contents/{contentId}
        ///     Rate Limit Group: Light
        ///     App Permission: SocialMessaging
        /// </summary>
        public async Task<string> Get(RestRequestConfig restRequestConfig = null)
        {
            if (contentId == null) throw new ArgumentException("Parameter cannot be null", nameof(contentId));
            return await rc.Get<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Cx.SocialMessaging.V1
{
    public partial class Index
    {
        public Contents.Index Contents(string contentId = null)
        {
            return new Contents.Index(this, contentId);
        }
    }
}