// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace UILayer.UILayer.Views
{
	[Register ("LoginViewController")]
	partial class LoginViewController
	{
		[Outlet]
		UIKit.UILabel ErrorLabel { get; set; }

		[Outlet]
		UIKit.UIButton LoginButton { get; set; }

		[Outlet]
		UIKit.UITextField PasswordTextField { get; set; }

		[Outlet]
		UIKit.UIButton RegisterButton { get; set; }

		[Outlet]
		UIKit.UITextField UsernameTextField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ErrorLabel != null) {
				ErrorLabel.Dispose ();
				ErrorLabel = null;
			}

			if (LoginButton != null) {
				LoginButton.Dispose ();
				LoginButton = null;
			}

			if (PasswordTextField != null) {
				PasswordTextField.Dispose ();
				PasswordTextField = null;
			}

			if (RegisterButton != null) {
				RegisterButton.Dispose ();
				RegisterButton = null;
			}

			if (UsernameTextField != null) {
				UsernameTextField.Dispose ();
				UsernameTextField = null;
			}
		}
	}
}
