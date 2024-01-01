using System.ComponentModel.DataAnnotations;

namespace YavinOffice.Model
{
    public class SiteVisitorInfor
    {
        [Key]
        public int VisitorId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int PhoneNumber { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
    }
}
