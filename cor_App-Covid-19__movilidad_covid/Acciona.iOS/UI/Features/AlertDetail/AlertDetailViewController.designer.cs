﻿// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Acciona.iOS.UI.Features.AlertDetail
{
    [Register ("AlertDetailViewController")]
    partial class AlertDetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonBack { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel DateLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView DescriptionTextView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView SeparatorView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TitleLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TitleViewLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttonBack != null) {
                buttonBack.Dispose ();
                buttonBack = null;
            }

            if (DateLabel != null) {
                DateLabel.Dispose ();
                DateLabel = null;
            }

            if (DescriptionTextView != null) {
                DescriptionTextView.Dispose ();
                DescriptionTextView = null;
            }

            if (SeparatorView != null) {
                SeparatorView.Dispose ();
                SeparatorView = null;
            }

            if (TitleLabel != null) {
                TitleLabel.Dispose ();
                TitleLabel = null;
            }

            if (TitleViewLabel != null) {
                TitleViewLabel.Dispose ();
                TitleViewLabel = null;
            }
        }
    }
}