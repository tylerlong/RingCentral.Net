using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Device
{
    public class Index
    {
        public string deviceId;
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent, string deviceId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.deviceId = deviceId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && deviceId != null) return $"{parent.Path()}/device/{deviceId}";
            return $"{parent.Path()}/device";
        }

        /// <summary>
        ///     Returns account device(s) by their ID(s).
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/device/{deviceId}
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyDevices
        /// </summary>
        public async Task<GetDeviceInfoResponse> Get(ReadDeviceParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GetDeviceInfoResponse>(Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Updates account device(s) by their ID(s).
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/device/{deviceId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: EditCompanyDevices
        /// </summary>
        public async Task<GetDeviceInfoResponse> Put(AccountDeviceUpdate accountDeviceUpdate,
            UpdateDeviceParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<GetDeviceInfoResponse>(Path(), accountDeviceUpdate, queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Device.Index Device(string deviceId = null)
        {
            return new Device.Index(this, deviceId);
        }
    }
}