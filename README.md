# TagHelperSuite ![build status](https://scottaddie.visualstudio.com/_apis/public/build/definitions/957b8877-2f05-4a7d-960c-12bbdfee0a91/1/badge)

## Overview

This collection of Tag Helpers will evolve and expand over time. For now, it includes the following:

1. `<link-button>` - Produces an anchor element which posts the form in which it's placed. Brings ASP.NET 4.x Web Forms LinkButton control behavior to ASP.NET Core MVC and Razor Pages.

	Consider the following markup in the *Index.cshtml* file of a Razor Pages app:
	
	```html
	<form asp-page-handler="Post">
	    <link-button>Test Link</link-button>
	</form>
	```
	
	When clicked, the associated page model's `OnPost` handler is invoked:
	
	```csharp
	public class IndexModel : PageModel
	{
	    public void OnPost()
	    {
	    }
	}
	```

## Installation

1. Add a reference to the [NuGet package](https://www.nuget.org/packages/TagHelperSuite/):
	```console
	dotnet add package TagHelperSuite
	```

1. Restore NuGet package:
	```console
	dotnet restore
	```

1. Register the Tag Helpers in *_ViewImports.cshtml*:
	```cshtml
	@addTagHelper *, TagHelperSuite
	```

## Acknowledgements

Credit goes to [Isaac Levin](https://twitter.com/isaac2004) for the idea that lead to the creation of the `<link-button>` Tag Helper.
	
