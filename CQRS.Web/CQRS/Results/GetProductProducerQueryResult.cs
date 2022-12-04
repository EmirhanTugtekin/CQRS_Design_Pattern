namespace CQRS.Web.CQRS.Results
{
    public class GetProductProducerQueryResult
    {
        //Product entity'deki üreticiye lazım olan property'ler
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductStorage { get; set; }
        public bool ProductStatus { get; set; }
    }
}
