using System;
using Xamarin.Forms;
using TestACEView.iOS; 
using Foundation; 

[assembly: Dependency (typeof (BaseUrl_iOS))]
namespace TestACEView.iOS
{
	public class BaseUrl_iOS : IBaseUrl {
		public string Get () {
			return NSBundle.MainBundle.BundlePath;
		}
	}
}

