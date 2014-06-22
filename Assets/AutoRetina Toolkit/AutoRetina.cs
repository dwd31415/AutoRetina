using UnityEngine;
using System.Collections;

public class AutoRetina{
	static Resolution stdResolution;
	public static void AutoSwitchResolution(iPhoneGeneration[] nonRetinaDevices)
	{
		if (stdResolution.width == 0) {
			stdResolution=Screen.currentResolution;
		}
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
						Screen.SetResolution (stdResolution.width,stdResolution.height ,true);
		}
	}
	public static void AutoSwitchResolution(int minRetinaGraphicsMemory)
	{
		if (stdResolution.width == 0) {
			stdResolution=Screen.currentResolution;
		}
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
						if (SystemInfo.graphicsMemorySize < minRetinaGraphicsMemory) {
								if(Screen.width == RetinaResolutions.iPadRetina.x || Screen.width==RetinaResolutions.iPadRetina.y) {
										Screen.SetResolution (1024, 768,true);	
								} else {
										Screen.SetResolution (480, 320,true);
								}

						}
						else{
								Screen.SetResolution (stdResolution.width,stdResolution.height ,true);
						}
		}
	}
	public static void AutoSwitchResolution(AppleGPUS minRetinaGPU)
	{
		if (stdResolution.width==0) {
			stdResolution=Screen.currentResolution;
		}
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			if (AppleGPUHelper.DetectGPU() < minRetinaGPU) {
				if (Screen.width == RetinaResolutions.iPadRetina.x || Screen.width==RetinaResolutions.iPadRetina.y) {
					Screen.SetResolution (1024, 768,true);	
				} else {
					Screen.SetResolution (480, 320,true);
				}
			}
			if (AppleGPUHelper.DetectGPU() >= minRetinaGPU) {
				Screen.SetResolution (stdResolution.width,stdResolution.height ,true);
			}
		}
	}


}
