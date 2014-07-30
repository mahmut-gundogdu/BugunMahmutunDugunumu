using System;
using Android.Webkit;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace DugunBugunMu
{
	[Activity (Label = "Düğün bu gün mü?", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		 
		WebView web_view;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			web_view = FindViewById<WebView> (Resource.Id.webview);
			web_view.Settings.JavaScriptEnabled = true;
			web_view.LoadUrl ("http://bugunmahmutundugunumu.info");
			 
		}
	}
}


