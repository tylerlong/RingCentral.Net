namespace RingCentral.Paths.Restapi.Account.AuditTrail
{
    public partial class Index
    {
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/audit-trail";
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public AuditTrail.Index AuditTrail()
        {
            return new AuditTrail.Index(this);
        }
    }
}