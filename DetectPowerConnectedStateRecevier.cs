
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

namespace PruebaJackAudio
{
	[BroadcastReceiver]
	[IntentFilter (new[] {Intent.ActionBatteryChanged, Intent.ActionPowerConnected, Intent.ActionPowerDisconnected})]
	public class DetectPowerConnectedStateRecevier : BroadcastReceiver
	{
		public override void OnReceive(Context context, Intent intent)
		{
			if (intent.Action == Intent.ActionPowerConnected)
			{
				Toast.MakeText (context, "Power Connected", ToastLength.Long).Show ();
			}

			if (intent.Action == Intent.ActionPowerDisconnected)
			{
				Toast.MakeText (context, "Power Disconnected", ToastLength.Long).Show ();
			}
		}
	}
	}
}

