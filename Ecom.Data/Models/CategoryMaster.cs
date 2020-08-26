namespace Ecom.Data.Models
{
    public partial class CategoryMaster : BaseModel
    {
        //public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public int? ReturnTypeId { get; set; }
    }
}
