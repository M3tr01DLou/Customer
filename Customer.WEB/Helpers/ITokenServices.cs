namespace Customer.WEB.Helpers
{
    public interface ITokenServices
    {
        string VerifySignatureAndRefresh(string token);
    }
}
