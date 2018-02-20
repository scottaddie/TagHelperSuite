using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TagHelperSuite.Tests.Infrastructure
{
    public class TagHelperFixture
    {
        private readonly TagHelperAttributeList _inputAttributes;
        private readonly Dictionary<object, object> _items = new Dictionary<object, object>();
        private readonly TagHelperAttributeList _outputAttributes;

        public TagHelperFixture()
        {
            _inputAttributes = new TagHelperAttributeList();
            _outputAttributes = new TagHelperAttributeList();
        }

        public TagHelperContext CreateContext()
        {
            var context = new TagHelperContext(
                _inputAttributes,
                _items,
                Guid.NewGuid().ToString("N"));

            return context;
        }

        public TagHelperOutput CreateOutput(string tagName)
        {
            var output = new TagHelperOutput(
                tagName,
                _outputAttributes,
                (cache, encoder) => Task.FromResult<TagHelperContent>(new DefaultTagHelperContent()));

            return output;
        }
    }
}
