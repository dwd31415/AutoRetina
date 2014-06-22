using UnityEngine;
using System.Collections;

public class AutoRetina{

	public static void AutoSwitchResolution(iPhoneGeneration[] nonRetinaDevices)
	{
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
						foreach (iPhoneGeneration generation in nonRetinaDevices) {
								if (iPhone.generation == generation) {
									if (Screen.width == RetinaResolutions.iPadRetina.x || Screen.width==RetinaResolutions.iPadRetina.y)  {
												Screen.SetResolution (1024, 768,true);	
												return;
										} else {
												Screen.SetResolution (480, 320,true);
												return;
										}
								}
						}
						Screen.SetResolution (Screen.resolutions[Screen.resolutions.Length-1].width,Screen.resolutions[Screen.resolutions.Length-1].height ,true);
			}
	}
	public static void AutoSwitchResolution(int minRetinaGraphicsMemory)
	{
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
						if (SystemInfo.graphicsMemorySize < minRetinaGraphicsMemory) {
								if(Screen.width == RetinaResolutions.iPadRetina.x || Screen.width==RetinaResolutions.iPadRetina.y) {
										Screen.SetResolution (1024, 768,true);	
								} else {
										Screen.SetResolution (480, 320,true);
								}

						}
						else{
								Screen.SetResolution (Screen.resolutions[Screen.resolutions.Length-1].width,Screen.resolutions[Screen.resolutions.Length-1].height ,true);
						}
		}
	}
	public static void AutoSwitchResolution(AppleGPUS minRetinaGPU)
	{
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			if (AppleGPUHelper.DetectGPU() < minRetinaGPU) {
				if (Screen.width == RetinaResolutions.iPadRetina.x || Screen.width==RetinaResolutions.iPadRetina.y) {
					Screen.SetResolution (1024, 768,true);	
				} else {
					Screen.SetResolution (480, 320,true);
				}
			}
			if (AppleGPUHelper.DetectGPU() >= minRetinaGPU) {
				Screen.SetResolution (Screen.resolutions[Screen.resolutions.Length-1].width,Screen.resolutions[Screen.resolutions.Length-1].height ,true);
			}
		}
	}


}
