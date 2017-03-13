using System;
using UIKit;
using Foundation;

namespace Xam.DownPicker.Sample
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			//Data
			NSMutableArray array = new NSMutableArray();
			array.Add(new NSString("First"));
			array.Add(new NSString("Second"));
			array.Add(new NSString("Third"));
			array.Add(new NSString("Fourth"));
			array.Add(new NSString("Fifth"));
			//Add Data to our down picker outlet
			UIDownPicker picker = new UIDownPicker(array);
			picker.Frame = this.containerView.Bounds;

			this.containerView.AddSubview(picker);

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
