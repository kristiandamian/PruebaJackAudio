
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Media;

namespace PruebaJackAudio
{
	[BroadcastReceiver]
	public class NoisyAudioStreamReceiver : BroadcastReceiver
	{
		public override void OnReceive (Context context, Intent intent)
		{
			if (Intent.ActionMediaButton.Equals (intent.Action)) {
				Toast.MakeText (context, "Received intent ActionMediaButton!", ToastLength.Short).Show ();
			}
			if (AudioManager.ActionAudioBecomingNoisy.Equals (intent.Action)) {
				Toast.MakeText (context, "Received intent ActionAudioBecomingNoisy!", ToastLength.Short).Show ();
			}
		}
	}
}