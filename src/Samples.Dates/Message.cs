using System;
namespace Samples.Dates
{
	public class Message
	{
		public string Title
		{
			private set; get;
		}
		public DateTime DateCreated
		{
			//get { return DateTime.Today; }
			get { return DateTime.Now; }
		}
		public string Description
		{
			set; get;
		}
		private Message() { }
		public Message(string title)
		{
			Title = title;
		}
	}
}
