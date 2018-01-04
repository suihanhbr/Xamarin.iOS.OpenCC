using System;

using UIKit;
using OpenCC;
using System.Diagnostics;

namespace TestSuiHanOpenCC {
	public partial class ViewController : UIViewController {
		protected ViewController(IntPtr handle) : base(handle) {
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad() {
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			foreach (var i in Enum.GetValues(typeof(OpenCCServiceConverterType))) {
				OpenCCService p = new OpenCCService((OpenCC.OpenCCServiceConverterType)i);
				//button.Text = p.convert("我们是好人");
				Debug.WriteLine(p.Convert("我们能够"));
			}
		}

		public override void DidReceiveMemoryWarning() {
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
