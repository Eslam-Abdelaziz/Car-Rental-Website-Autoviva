namespace CarRental.Data.Models
{
	public class JWTAccessToken
    {
        public string Token { get; set; }

        public JWTAccessToken(string Token) 
        {
            this.Token = Token;
        }
    }
}
