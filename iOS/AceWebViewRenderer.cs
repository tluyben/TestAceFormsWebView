using System;
using Foundation;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using TestACEView;
using TestACEView.iOS;

[assembly: ExportRenderer (typeof (AceWebView), typeof (AceWebViewRenderer))]
namespace TestACEView.iOS
{
	public class AceWebViewRenderer : WebViewRenderer  {
		public override void LoadHtmlString (string s, NSUrl baseUrl)  {
			baseUrl = new NSUrl (NSBundle.MainBundle.BundlePath, true);
			base.LoadHtmlString (s, baseUrl);
		}
	}
}

