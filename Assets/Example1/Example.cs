using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour {


	void OnGUI()
	{
		if(GUI.Button(new Rect(0,0,0.2f*Screen.width,0.1f*Screen.height),"Retina > A4"))
		{
			AutoRetina.AutoSwitchResolution(AppleGPUS.A4);
		}
		if(GUI.Button(new Rect(0.4f*Screen.width,0,0.2f*Screen.width,0.1f*Screen.height),"Retina > A5"))
		{
			AutoRetina.AutoSwitchResolution(AppleGPUS.A5);
		}
		if(GUI.Button(new Rect(0.80f*Screen.width,0,0.2f*Screen.width,0.1f*Screen.height),"Retina > A6"))
		{
			AutoRetina.AutoSwitchResolution(AppleGPUS.A6);
		}
	}
}
