using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace TagHelperSuite.Tests
{
    public class LinkButtonTagHelperTests
    {
        [Fact]
        public void ProcessGeneratesExpectedRootElement()
        {
            // ==== Arrange ====
            const string ROOT_HTML_ELEMENT_TAG = "a";

            var context = new TagHelperContext(
                new TagHelperAttributeList(),
                new Dictionary<object, object>(),
                Guid.NewGuid().ToString("N"));

            var output = new TagHelperOutput(
                ROOT_HTML_ELEMENT_TAG,
                new TagHelperAttributeList(),
                (cache, encoder) => Task.FromResult<TagHelperContent>(new DefaultTagHelperContent()));

            var tagHelper = new LinkButtonTagHelper();

            // ==== Act ====
            tagHelper.Process(context, output);

            // ==== Assert ====
            // Compare root HTML elements
            Assert.Equal(ROOT_HTML_ELEMENT_TAG, output.TagName);
        }
    }
}
