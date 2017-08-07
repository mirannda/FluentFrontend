﻿using System.Collections.Generic;
using System.Text;

namespace FluentFrontend.Html
{
    public static class HtmlExtensions
    {
        public static FluentHtmlHelper Html(this IFluentHelper helper) => new FluentHtmlHelper(helper);

        public static IElement<Tag> P(this FluentHtmlHelper helper) => helper.GetElement(new Tag("p"));

        public static IElement<Div> Div(this FluentHtmlHelper helper) => helper.GetElement(new Div());
    }
}
