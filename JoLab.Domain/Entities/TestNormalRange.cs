namespace JoLab.Domain.Entities
{
    public class TestNormalRange : BaseEntity<Guid>
    {
        public string NameAr { get; set; }
        public string NameOt { get; set; }
        public decimal NormalValue { get; set; }
        public Guid  TestId { get; set; }   
        public virtual Test Test { get; set; }
        
    }

}
