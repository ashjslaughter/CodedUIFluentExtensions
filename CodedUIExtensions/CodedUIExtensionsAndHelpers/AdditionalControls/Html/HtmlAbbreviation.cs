﻿using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using CodedUIExtensionsAndHelpers.Fluent;

namespace CodedUIExtensionsAndHelpers.AdditionalControls.Html
{
    public class HtmlAbbreviation : HtmlCustomTag
    {
        public static readonly string AbbreviationTag = "abbr";
        public static readonly string TitleAttributeName = "title";

        public HtmlAbbreviation() : base(AbbreviationTag) { }
        public HtmlAbbreviation(UITestControl parent) : base(parent, AbbreviationTag) { }

        public string Title
        {
            get
            {
                return this.GetPropertyOrDefault(TitleAttributeName, null);
            }
        }
    }
}