namespace Ecom.API.Models
{
    public partial class VarianceMaster
    {

        public int Id { get; set; }
        public string VarianceName { get; set; }
        public bool IsActive { get; set; }
        public bool IncludeInTitle { get; set; }

    }
}
