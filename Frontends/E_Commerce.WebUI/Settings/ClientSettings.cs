namespace E_Commerce.WebUI.Settings
{
    public class ClientSettings
    {
        public Client E_CommerceVisitorClient { get; set; }
        public Client E_CommerceManagerClient { get; set; }
        public Client E_CommerceAdminClient { get; set; }
    }
    public class Client
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
