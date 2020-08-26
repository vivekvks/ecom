namespace Ecom.API.Models
{
    public partial class VarianceValue
    {

        public int Id { get; set; }
        public int VarianceId { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }

    }
}
