using System;

using Xamarin.Forms;

namespace TestACEView
{
	public interface IBaseUrl { string Get(); }
	public class AceWebView : WebView { }

	public class App : Application
	{


		public App ()
		{

			var webView = new AceWebView {

			};

			var html = new HtmlWebViewSource ();

			if (Device.OS != TargetPlatform.iOS) {
				// the BaseUrlWebViewRenderer does this for iOS, until bug is fixed
				html.BaseUrl = DependencyService.Get<IBaseUrl> ().Get ();
			}
				
			html.Html = @"

	<!DOCTYPE html>
<html lang=""en"">
<head>
  <meta charset=""UTF-8"">
  <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
  <title>Editor</title>
  <style type=""text/css"" media=""screen"">
    body {
        overflow: hidden;
    }
    #editor {
        margin: 0;
        position: absolute;
        top: 0;
        bottom: 0;
        left: 0;
        right: 0;
    }
  </style>
</head>
<body>

<pre id=""editor"">function foo(items) {
    var i;
    for (i = 0; i &lt; items.length; i++) {
        alert(""Ace Rocks "" + items[i]);
    }
}</pre>

<script src=""ace.js"" type=""text/javascript"" charset=""utf-8""></script>
<script>
    var editor = ace.edit(""editor"");
    editor.setTheme(""ace/theme/twilight"");
    editor.getSession().setMode(""ace/mode/javascript"");
</script>

</body>
</html>

";
			
			webView.Source = html;

			MainPage = new ContentPage {
				Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5),
				Content = webView
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

