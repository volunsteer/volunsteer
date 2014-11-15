using System;
using System.Reflection;
using Xamarin.Forms;

namespace Volunsteer
{
	public class App
	{
		public static Page GetMainPage ()
		{
			#if DEBUG
			System.Diagnostics.Debug.WriteLine("===============");
			var assembly = typeof(App).GetTypeInfo().Assembly;
			foreach (var res in assembly.GetManifestResourceNames()) {
				System.Diagnostics.Debug.WriteLine ("found resource: " + res);
			}
			#endif

			if (Device.OS != TargetPlatform.WinPhone) {
				DependencyService.Get<ILocalize> ().SetLocale ();
				AppResources.Culture = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
			}

			return new HelloPage ();
		}
	}
}

