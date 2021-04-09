namespace RingCentral
{
    public class PromptInfo
    {
        /// <summary>
        ///     Internal identifier of a prompt
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Link to a prompt metadata
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Type of a prompt media content
        /// </summary>
        public string contentType { get; set; }

        /// <summary>
        ///     Link to a prompt media content
        /// </summary>
        public string contentUri { get; set; }

        /// <summary>
        ///     Name of a prompt
        /// </summary>
        public string filename { get; set; }
    }
}