using Android.Telephony;

namespace WSAndroid {
public class GsmSignalStrengthListener : PhoneStateListener
{
	public delegate void SignalStrengthChangedDelegate(int strength);

	public event SignalStrengthChangedDelegate SignalStrengthChanged;

	public override void OnSignalStrengthsChanged(SignalStrength newSignalStrength)
	{
		if (newSignalStrength.IsGsm)
		{
			if (SignalStrengthChanged != null)
			{
				SignalStrengthChanged(newSignalStrength.GsmSignalStrength);
			}
		}
	}
}
}

