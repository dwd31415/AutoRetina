using UnityEngine;
using System.Collections;

public class AutoRetina : MonoBehaviour {

	public static void AutoSwitchResolution(iPhoneGeneration[] nonRetinaDevices)
	{
		foreach (iPhoneGeneration generation in nonRetinaDevices) {
			if(iPhone.generation==generation)
			{
				if(Screen.width==(RetinaResolutions.iPadRetina.x|RetinaResolutions.iPadRetina.y))
				{
					Screen.SetResolution(1024,768);	
				}
				else{
					Screen.SetResolution(480,320);
				}
			}
		}
	}
	public static void AutoSwitchResolution(int minRetinaGraphicsMemory)
	{
		if(SystemInfo.graphicsMemorySize<minRetinaGraphicsMemory) {

				if(Screen.width==(RetinaResolutions.iPadRetina.x|RetinaResolutions.iPadRetina.y))
				{
					Screen.SetResolution(1024,768);	
				}
				else{
					Screen.SetResolution(480,320);
				}

		}
	}


}
