namespace HelpPeople.Data.Model
{
    public class Cart
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }
        public DateTime created_at { get; set; }
    }
}
