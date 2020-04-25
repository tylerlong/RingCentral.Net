using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Glip.Chats.Notes
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Chats.Index parent;

        public Index(Restapi.Glip.Chats.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/notes";
        }

        /// <summary>
        /// Operation: Create Note
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/chats/{chatId}/notes
        /// Rate Limit Group: Medium
        /// App Permission Required: Glip
        /// User Permission Required: Glip
        /// </summary>
        public async Task<RingCentral.GlipNoteInfo> Post(RingCentral.GlipNoteCreate glipNoteCreate,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.GlipNoteInfo>(this.Path(), glipNoteCreate, null, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Chat Notes
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/chats/{chatId}/notes
        /// Rate Limit Group: Heavy
        /// App Permission Required: Glip
        /// User Permission Required: Glip
        /// </summary>
        public async Task<RingCentral.GlipNotesInfo> Get(ListChatNotesParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.GlipNotesInfo>(this.Path(), queryParams, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Chats
{
    public partial class Index
    {
        public Restapi.Glip.Chats.Notes.Index Notes()
        {
            return new Restapi.Glip.Chats.Notes.Index(this);
        }
    }
}