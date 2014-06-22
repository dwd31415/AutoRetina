using UnityEngine;
using System.Collections;


public class RetinaResolutions{
	public static Vector2 iPhone5Retina=new Vector2(1136,640);
	public static Vector2 iPhone4SRetina=new Vector2(960,640);
	public static Vector2 iPadRetina=new Vector2(2048,1536);
}

public enum AppleGPUS:short{
	None=1,A3,A4,A5,A5X,A6,A6X,A7
}

public class AppleGPUHelper
{
	public static AppleGPUS DetectGPU()
	{
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			switch(iPhone.generation)
			{
			case iPhoneGeneration.iPhone3GS:
				return AppleGPUS.A3;
				break;
			case iPhoneGeneration.iPhone4:
				return AppleGPUS.A4;
				break;
			case iPhoneGeneration.iPhone4S:
				return AppleGPUS.A5;
				break;
			case iPhoneGeneration.iPhone5:
				return AppleGPUS.A6;
				break;
			case iPhoneGeneration.iPhone5C:
				return AppleGPUS.A6;
				break;
			case iPhoneGeneration.iPhone5S:
				return AppleGPUS.A7;
				break;
			case iPhoneGeneration.iPodTouch4Gen:
				return AppleGPUS.A4;
				break;
			case iPhoneGeneration.iPodTouch5Gen:
				return AppleGPUS.A5;
				break;
			case iPhoneGeneration.iPad1Gen:
				return AppleGPUS.A4;
				break;
			case iPhoneGeneration.iPad2Gen:
				return AppleGPUS.A5;
				break;
			case iPhoneGeneration.iPad3Gen:
				return AppleGPUS.A5X;
				break;
			case iPhoneGeneration.iPad4Gen:
				return AppleGPUS.A6X;
				break;
			case iPhoneGeneration.iPad5Gen:
				return AppleGPUS.A7;
				break;
			case iPhoneGeneration.iPadMini1Gen:
				return AppleGPUS.A5;
				break;
			case iPhoneGeneration.iPadMini2Gen:
				return AppleGPUS.A7;
				break;
			}
			return AppleGPUS.None;
		} else {
			return AppleGPUS.None;
		}
	}
}