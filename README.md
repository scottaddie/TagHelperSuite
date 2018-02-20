# TagHelperSuite ![build status](https://scottaddie.visualstudio.com/_apis/public/build/definitions/957b8877-2f05-4a7d-960c-12bbdfee0a91/1/badge)

## Overview

This collection of Tag Helpers will evolve and expand over time. For now, it includes the following:
1. `<link-button>` - Produces an anchor element which posts the form in which it's placed. Brings ASP.NET 4.x Web Forms LinkButton control behavior to ASP.NET Core MVC and Razor Pages.

## Installation & Usage

1. Add a reference to the NuGet package:
	```console
	dotnet add package TagHelperSuite
	```

1. Register the Tag Helpers in *_ViewImports.cshtml*:
	```cshtml
	@addTagHelper *, TagHelperSuite
	```

1. Use the Tag Helper inside of a `<form>` tag in Razor Pages or MVC apps. For example, here's a sample from a Razor Pages app:
	```html
	<form asp-page-handler="Post">
		<link-button>Test Link</link-button>
	</form>
	```