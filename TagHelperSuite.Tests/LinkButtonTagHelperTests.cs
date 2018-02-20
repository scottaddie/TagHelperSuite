using TagHelperSuite.Tests.Infrastructure;
using Xunit;

namespace TagHelperSuite.Tests
{
    public class LinkButtonTagHelperTests : IClassFixture<TagHelperFixture>
    {
        private readonly TagHelperFixture _fixture;
        private const string ROOT_HTML_ELEMENT_TAG = "a";

        public LinkButtonTagHelperTests(TagHelperFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void ProcessGeneratesExpectedRootElement()
        {
            // ==== Arrange ====
            var context = _fixture.CreateContext();
            var output = _fixture.CreateOutput(ROOT_HTML_ELEMENT_TAG);
            var tagHelper = new LinkButtonTagHelper();

            // ==== Act ====
            tagHelper.Process(context, output);

            // ==== Assert ====
            // Compare root HTML elements
            Assert.Equal(ROOT_HTML_ELEMENT_TAG, output.TagName);
        }
    }
}
