using System;
using UnityEngine;
using UnityEngine.CrashLog;
using System.Collections;

public class ThrowMeAnException : MonoBehaviour 
{
	public GameObject obj;
	private Transform t = null;

	public void CrashForMe()
	{
		throw new Exception("Button press exception");
	}

	public void DoUnassignedNow() {

		// obj reference is not set
		obj.transform.Translate( Vector3.zero );
	}

	public void DoNullReferenceNow() {
		
		// obj reference is not set
		t.Translate( Vector3.zero );
	}
}
