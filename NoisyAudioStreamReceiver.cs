
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

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
		Timer timer;
		public string NoisyName { get { return Class.Name; } }

		public override void OnReceive (Context context, Intent intent)
		{
			
			if (Intent.ActionMediaButton.Equals (intent.Action)) {
				Toast.MakeText (context, "Se presiono el boton del manos libres!", ToastLength.Short).Show ();
				ClickCounter.addClick ();
				TimerTicker.start ();

			}
			var keyEvent = (KeyEvent)intent.GetParcelableExtra(Intent.ExtraKeyEvent);

			switch (keyEvent.KeyCode)
			{
			case Keycode.MediaPlay:
				Toast.MakeText (context, "play!", ToastLength.Short).Show ();
				break;
			case Keycode.MediaPlayPause:
				Toast.MakeText (context, "pausa!", ToastLength.Short).Show ();
				break;
			case Keycode.MediaNext:
				Toast.MakeText (context, "Next!", ToastLength.Short).Show ();
				break;
			case Keycode.MediaPrevious:
				Toast.MakeText (context, "Previous!", ToastLength.Short).Show ();
				break;
			}

		}

	}
	public static class TimerTicker
	{
		static Timer timer;
		public static void start(){
			if (timer == null) {
				timer = new System.Timers.Timer (2000);
				timer.Elapsed += Timer_Elapsed;
				timer.Start ();
			}
		}
		static void Timer_Elapsed (object sender, System.Timers.ElapsedEventArgs e)
		{
			//clicks = 0;
			var clicks=ClickCounter.getClick();
			ClickCounter.cleanClick();
			timer.Stop ();
			timer = null;
		}
	}


	public static class ClickCounter
	{
		static int _clicks;
		public static void addClick()
		{
			_clicks++;
		}
		public static int getClick()
		{
			return _clicks;
		}
		public static void cleanClick()
		{
			_clicks = 0;
		}
	}
}