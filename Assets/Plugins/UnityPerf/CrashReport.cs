using UnityEngine;
using System.Collections;
using UnityEngine.CrashLog;

public class CrashReport : MonoBehaviour {

	void Awake() {
		CrashReporting.Init("2642ef7f-3ff6-40fc-b135-45ecec703ff3", "1.0.0", "UserNameHoge");
	}
}
