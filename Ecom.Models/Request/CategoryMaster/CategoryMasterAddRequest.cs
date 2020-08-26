namespace Ecom.Models.Request
{
    public class CategoryMasterAddRequest
    {
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public int ReturnTypeId { get; set; }
    }
}
