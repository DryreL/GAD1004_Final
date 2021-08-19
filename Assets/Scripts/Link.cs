using UnityEngine;
using System.Runtime.InteropServices;

public class Link : MonoBehaviour {
	public void OpenLinkJSPlugin() {
		#if !UNITY_EDITOR
		openWindow("http://unity3d.com");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);
}