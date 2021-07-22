using UnityEngine;
using System.Runtime.InteropServices;

public class OpenLinkJS : MonoBehaviour
{
	public void OpenLinkJSPlugin(string link)
	{
#if !UNITY_EDITOR
		openWindow("link");
#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);
}