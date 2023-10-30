namespace RingCentral.Paths.Restapi.V2.Accounts.Licenses
{
    public partial class Index
    {
        public Accounts.Index parent;
        public RestClient rc;

        public Index(Accounts.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/licenses";
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts
{
    public partial class Index
    {
        public Licenses.Index Licenses()
        {
            return new Licenses.Index(this);
        }
    }
}