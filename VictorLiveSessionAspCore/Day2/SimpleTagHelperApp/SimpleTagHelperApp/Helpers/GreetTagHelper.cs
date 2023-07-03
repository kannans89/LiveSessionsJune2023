using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SimpleTagHelperApp.Helpers
{
	public class GreetTagHelper:TagHelper
	{
		public string DevName { get; set; } = "";
		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			output.TagName = "H1";//some html element
			output.Content.SetContent($"Hello developer {DevName} , how are you ?");
		}
	}
}
