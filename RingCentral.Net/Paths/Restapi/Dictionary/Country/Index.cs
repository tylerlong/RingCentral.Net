using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Dictionary.Country
{
    public partial class Index
    {
        public RestClient rc;
        public string countryId;
        public Restapi.Dictionary.Index parent;

        public Index(Restapi.Dictionary.Index parent, string countryId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.countryId = countryId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && countryId != null)
            {
                return $"{parent.Path()}/country/{countryId}";
            }

            return $"{parent.Path()}/country";
        }

        /// <summary>
        /// Operation: Get Country List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/dictionary/country
        /// Rate Limit Group: Light
        /// App Permission Required: undefined
        /// User Permission Required: undefined
        /// </summary>
        public async Task<RingCentral.GetCountryListResponse> List(ListCountriesParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.GetCountryListResponse>(this.Path(false), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Country
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/dictionary/country/{countryId}
        /// Rate Limit Group: Light
        /// App Permission Required: undefined
        /// User Permission Required: undefined
        /// </summary>
        public async Task<RingCentral.GetCountryInfoDictionaryResponse> Get(CancellationToken? cancellationToken = null)
        {
            if (this.countryId == null)
            {
                throw new System.ArgumentNullException("countryId");
            }

            return await rc.Get<RingCentral.GetCountryInfoDictionaryResponse>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public Restapi.Dictionary.Country.Index Country(string countryId = null)
        {
            return new Restapi.Dictionary.Country.Index(this, countryId);
        }
    }
}