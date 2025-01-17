namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation syncUserCallLog
    /// </summary>
    public class SyncUserCallLogParameters
    {
        /// <summary>
        ///     Type of call log synchronization request: full or incremental sync
        ///     Default: FSync
        ///     Enum: FSync, ISync
        /// </summary>
        public string syncType { get; set; }

        /// <summary>
        ///     A `syncToken` value from the previous sync response (for `ISync` mode only, mandatory)
        /// </summary>
        public string syncToken { get; set; }

        /// <summary>
        ///     Starting date for the resulting records in ISO 8601 format, including
        ///     timezone, for example *2016-03-10T18:07:52.534Z*. The range is limited to the last 30 days from the current moment.
        ///     If not specified, the default value is a log history date (date of account creation/call log deletion), and
        ///     no time range limitation applied
        ///     Format: date-time
        /// </summary>
        public string dateFrom { get; set; }

        /// <summary>
        ///     For `FSync` mode this parameter is mandatory, it limits the number of records to be returned in response.
        ///     For `ISync` mode this parameter specifies the number of records to extend the sync frame with to the past
        ///     (the maximum number of records is 250)
        ///     Format: int32
        /// </summary>
        public long? recordCount { get; set; }

        /// <summary>
        ///     Type of calls to be returned
        ///     Enum: Missed, All
        /// </summary>
        public string[] statusGroup { get; set; }

        /// <summary>
        ///     Defines the level of details for returned call records
        ///     Default: Simple
        ///     Enum: Simple, Detailed
        /// </summary>
        public string view { get; set; }

        /// <summary>
        ///     Supported for `ISync` mode. Indicates that deleted call records should be returned
        /// </summary>
        public bool? showDeleted { get; set; }

        /// <summary>
        ///     Deprecated, replaced with `recordingType` filter, still supported for compatibility reasons.
        ///     Indicates if only recorded calls should be returned.
        ///     If both `withRecording` and `recordingType` parameters are specified, then `withRecording` is ignored
        /// </summary>
        public bool? withRecording { get; set; }

        /// <summary>
        ///     Indicates that call records with recordings of particular type should be returned.
        ///     If omitted, then calls with and without recordings are returned
        ///     Enum: Automatic, OnDemand, All
        /// </summary>
        public string recordingType { get; set; }
    }
}