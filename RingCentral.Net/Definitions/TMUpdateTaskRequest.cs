namespace RingCentral
{
    public class TMUpdateTaskRequest
    {
        /// <summary>
        ///     Task name/subject. Max allowed length is 250 characters.
        /// </summary>
        public string subject { get; set; }

        /// <summary>
        /// </summary>
        public TMUpdateTaskRequestAssignees[] assignees { get; set; }

        /// <summary>
        ///     Enum: Simple, AllAssignees, Percentage
        /// </summary>
        public string completenessCondition { get; set; }

        /// <summary>
        ///     Task start date in UTC time zone
        ///     Format: date-time
        /// </summary>
        public string startDate { get; set; }

        /// <summary>
        ///     Task due date/time in UTC time zone
        ///     Format: date-time
        /// </summary>
        public string dueDate { get; set; }

        /// <summary>
        ///     Enum: Black, Red, Orange, Yellow, Green, Blue, Purple, Magenta
        /// </summary>
        public string color { get; set; }

        /// <summary>
        ///     Task section to group / search by. Max allowed length is 100 characters.
        /// </summary>
        public string section { get; set; }

        /// <summary>
        ///     Task details. Max allowed length is 102400 characters (100kB)
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// </summary>
        public TaskRecurrenceInfo recurrence { get; set; }

        /// <summary>
        /// </summary>
        public TMAttachmentInfo[] attachments { get; set; }
    }
}