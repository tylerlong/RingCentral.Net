namespace RingCentral
{
    // For 'Audio' mode only. Prompt media reference
    public class AudioPromptInfo
    {
        /// <summary>
        ///     Link to a prompt audio file
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a prompt
        /// </summary>
        public string id { get; set; }
    }
}