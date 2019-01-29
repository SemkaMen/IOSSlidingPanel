// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace iosslidingpanel
{
    [Register ("MainScreenViewController")]
    partial class MainScreenViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel BalanceLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        iosslidingpanel.GradientButton MakeTransactionButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel NameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton OptionButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        iosslidingpanel.GradientVIew ToolbarView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView TransactionsTabView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BalanceLabel != null) {
                BalanceLabel.Dispose ();
                BalanceLabel = null;
            }

            if (MakeTransactionButton != null) {
                MakeTransactionButton.Dispose ();
                MakeTransactionButton = null;
            }

            if (NameLabel != null) {
                NameLabel.Dispose ();
                NameLabel = null;
            }

            if (OptionButton != null) {
                OptionButton.Dispose ();
                OptionButton = null;
            }

            if (ToolbarView != null) {
                ToolbarView.Dispose ();
                ToolbarView = null;
            }

            if (TransactionsTabView != null) {
                TransactionsTabView.Dispose ();
                TransactionsTabView = null;
            }
        }
    }
}