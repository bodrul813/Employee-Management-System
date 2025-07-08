

using System.Globalization;

namespace BaseLibrary.Entities
{
    public class Employee : BaseEntity
    {
        public string? CivilId { get; set; }
        public string? FileNumber { get; set; }
        public string? FullName { get; set; }
        public string? JobName { get; set; }
        public string? Address { get; set; }
        public string? TelPhoneNumber { get; set; }
        public string? Photo {  get; set; }
        public string? Other {  get; set; }

    }
}
