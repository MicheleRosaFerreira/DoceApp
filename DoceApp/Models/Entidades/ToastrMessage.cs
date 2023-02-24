namespace DoceApp.Models.Entidades
{
	public class ToastrMessage
	{
		public string Type { get; set; }
		public string Title { get; set; }
		public string Message { get; set; }

		public ToastrMessage(string type, string title , string message)
		{
			Type = type;
			Title = title;
			Message = message;
		}
	}
}
