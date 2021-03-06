﻿using CodedUIExtensionsAndHelpers.Fluent;
using CodedUIExtensionsAndHelpers.PageModeling;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CodedUIExtensionsAndHelpers.AdditionalControls.Win
{
    public class IESecurityWindow<T> : PageModelBase<WinWindow> // TODO: extend this model incase IE is not the browser being tested; do others pop security warnings in the same cases?
    {
        protected const string SecurityWindowName = "Internet Explorer Security";

        protected override WinWindow Me
        {
            get
            {
                return new WinWindow().Extend(WinWindow.PropertyNames.Name, SecurityWindowName, PropertyExpressionOperator.EqualTo);
            }
        }

        protected WinButton AllowButton
        {
            get
            {
                return this.Me.Find<WinButton>(WinButton.PropertyNames.Name, "Allow", PropertyExpressionOperator.EqualTo);
            }
        }

        internal readonly T AllowModel;
        public IESecurityWindow(T allowModel)
        {
            this.AllowModel = allowModel;
        }

        public T ClickAllow()
        {
            // if not IE, this will return false and the next model is returned
            if (this.AllowButton.IsActionable(3000))
            {
                Mouse.Click(this.AllowButton);
            }
            return AllowModel;
        }
    }
}