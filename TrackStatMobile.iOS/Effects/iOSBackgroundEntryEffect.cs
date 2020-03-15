using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using TrackStatMobile.iOS.Effects;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("TrackStatMobile")]
[assembly: ExportEffect(typeof(iOSBackgroundEntryEffect), "BackgroundEffect")]
namespace TrackStatMobile.iOS.Effects
{
    class iOSBackgroundEntryEffect : PlatformEffect
    {
		protected override void OnAttached()
		{
			try
			{
				var view = this.Control as UITextField;
				if (view == null)
					return;

				view.BorderStyle = UITextBorderStyle.Line;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
			}
		}

		protected override void OnDetached()
		{

		}
	}
}