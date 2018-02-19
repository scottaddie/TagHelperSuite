using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelperSuite
{
    /// <summary>
    /// Tag Helper to enable posting of a form with an anchor tag. Similar to the ASP.NET 4.x 
    /// Web Forms LinkButton control behavior.
    /// </summary>
    /// <remarks>
    /// Relies on the injection of a hidden form field to locate the parent form to be submitted
    /// </remarks>
    /// <example>
    ///     <code>
    ///         <form asp-page-handler="Post">
    ///             <link-button>Link Text</link-button>
    ///         </form>
    ///     </code>
    /// </example>
    [HtmlTargetElement("link-button")]
    public class LinkButtonTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            const string HIDDEN_FIELD_ID = "form_marker";

            output.TagName = "a";
            output.Attributes.SetAttribute("onclick",
                $@"document.getElementById(""{HIDDEN_FIELD_ID}"").form.submit();");

            output.PostElement.SetHtmlContent($@"<input type=""hidden"" id=""{HIDDEN_FIELD_ID}"" />");
        }
    }
}
