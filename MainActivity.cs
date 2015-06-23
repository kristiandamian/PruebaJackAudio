using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Media;

namespace PruebaJackAudio
{
	[Activity (Label = "PruebaJackAudio", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};

			//this.ApplicationContext.StartService (new  Intent (this.BaseContext, NoisyAudioStreamReceiver));
			/*IntentFilter filter = new IntentFilter ("ParseNoise");
			var noise = new NoisyAudioStreamReceiver ();
			RegisterReceiver (noise, filter);*/

			var am = (AudioManager) this.GetSystemService(AudioService);
			var componentName = new ComponentName(PackageName, new NoisyAudioStreamReceiver().NoisyName);
			am.RegisterMediaButtonEventReceiver(componentName);
		}
	}
}


