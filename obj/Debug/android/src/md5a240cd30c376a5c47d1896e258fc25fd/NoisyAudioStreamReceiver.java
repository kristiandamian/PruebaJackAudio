package md5a240cd30c376a5c47d1896e258fc25fd;


public class NoisyAudioStreamReceiver
	extends android.content.BroadcastReceiver
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onReceive:(Landroid/content/Context;Landroid/content/Intent;)V:GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler\n" +
			"";
		mono.android.Runtime.register ("PruebaJackAudio.NoisyAudioStreamReceiver, PruebaJackAudio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", NoisyAudioStreamReceiver.class, __md_methods);
	}


	public NoisyAudioStreamReceiver () throws java.lang.Throwable
	{
		super ();
		if (getClass () == NoisyAudioStreamReceiver.class)
			mono.android.TypeManager.Activate ("PruebaJackAudio.NoisyAudioStreamReceiver, PruebaJackAudio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onReceive (android.content.Context p0, android.content.Intent p1)
	{
		n_onReceive (p0, p1);
	}

	private native void n_onReceive (android.content.Context p0, android.content.Intent p1);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
