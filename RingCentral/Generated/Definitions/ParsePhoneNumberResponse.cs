using Newtonsoft.Json;

namespace RingCentral
{
    public class ParsePhoneNumberResponse : Serializable
    {
        // Canonical URI of a resource
        public string uri;
        // Information on a user home country
        public GetCountryInfoNumberParser[] homeCountry;
        // Parsed phone numbers data
        public PhoneNumberInfoNumberParser[] phoneNumbers;
    }
}