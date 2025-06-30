namespace UseExternal_APIS__ASP.NET_CORE_WEB_API_.Model
{
    public class CryptoCoin
    {
        public string Id { get; set; } = string.Empty;       
        public string Symbol { get; set; } = string.Empty;   
        public string Name { get; set; } = string.Empty;
        public decimal current_price { get; set; }
        public decimal total_supply { get; set; }

    }
}
