using System;
using Xamarin.Forms;
using TestACEView.Droid; 

[assembly: Dependency (typeof (BaseUrl_Android))]
namespace TestACEView.Droid
{
	public class BaseUrl_Android : IBaseUrl {
		public string Get () {
			return "file:///android_asset/";
		}
	}
}

