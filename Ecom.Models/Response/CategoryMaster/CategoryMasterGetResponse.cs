namespace Ecom.Models.Response
{
    public class CategoryMasterGetResponse
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public int? ReturnTypeId { get; set; }
    }
}
