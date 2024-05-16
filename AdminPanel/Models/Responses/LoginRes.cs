namespace AdminPanel.Models.Responses
{
	public class LoginRes
	{
		public string Token { get; set; }
		public User User { get; set; }

		public bool IsAdmin { get; set; }
	}
}
