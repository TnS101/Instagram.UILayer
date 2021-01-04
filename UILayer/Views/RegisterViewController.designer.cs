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
	[Register ("RegisterViewController")]
	partial class RegisterViewController
	{
		[Outlet]
		UIKit.UIButton AddImageButton { get; set; }

		[Outlet]
		UIKit.UITextField EmailTextField { get; set; }

		[Outlet]
		UIKit.UILabel ErrorLabel { get; set; }

		[Outlet]
		UIKit.UITextField PasswordTextField { get; set; }

		[Outlet]
		UIKit.UIButton RegisterButton { get; set; }

		[Outlet]
		UIKit.UITextField UsernameTextField { get; set; }

		[Outlet]
		UIKit.UITextField UserTagTextField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (AddImageButton != null) {
				AddImageButton.Dispose ();
				AddImageButton = null;
			}

			if (EmailTextField != null) {
				EmailTextField.Dispose ();
				EmailTextField = null;
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

			if (UserTagTextField != null) {
				UserTagTextField.Dispose ();
				UserTagTextField = null;
			}

			if (ErrorLabel != null) {
				ErrorLabel.Dispose ();
				ErrorLabel = null;
			}
		}
	}
}
