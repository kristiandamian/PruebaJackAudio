
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
	[BroadcastReceiver(Enabled = true)]
	[IntentFilter(new[] { Intent.ActionMediaButton })]
	public class NoisyAudioStreamReceiver : BroadcastReceiver
	{
		public string NoisyName { get { return Class.Name; } }
		public override void OnReceive (Context context, Intent intent)
		{
			if (Intent.ActionMediaButton.Equals (intent.Action)) {
				Toast.MakeText (context, "Se presiono el boton del manos libres!", ToastLength.Short).Show ();
			}
			var keyEvent = (KeyEvent)intent.GetParcelableExtra(Intent.ExtraKeyEvent);

			switch (keyEvent.KeyCode)
			{
			case Keycode.MediaPlay:
				break;
			case Keycode.MediaPlayPause:
				break;
			case Keycode.MediaNext:
				break;
			case Keycode.MediaPrevious:
				break;
			}
			if (AudioManager.ActionAudioBecomingNoisy.Equals (intent.Action)) {
				Toast.MakeText (context, "Received intent ActionAudioBecomingNoisy!", ToastLength.Short).Show ();
			}
		}
	}
}