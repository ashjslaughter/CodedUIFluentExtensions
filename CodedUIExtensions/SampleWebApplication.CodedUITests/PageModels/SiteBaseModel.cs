﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodedUIExtensionsAndHelpers.PageModeling;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace SampleWebApplication.CodedUITests.PageModels
{
    public class SiteBaseModel : HtmlDocumentPageModelBase
    {
        public SiteBaseModel(BrowserWindow bw) : base(bw) { }

        public NavigationStripBaseModel NavStrip
        {
            get { return new NavigationStripBaseModel(this.parent); }
        }
    }
}