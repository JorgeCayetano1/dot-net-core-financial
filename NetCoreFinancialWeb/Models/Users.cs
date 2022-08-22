namespace NetCoreFinancialWeb.Models
{
    public class Users
    {
        public int id { get; set; }
        public string? first_name { get; set; }
        public string? last_name { get; set; }
        public string? phone { get; set; }
        public string? email { get; set; }
        public bool status { get; set; }
    }
}
