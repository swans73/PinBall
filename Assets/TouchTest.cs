using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		var touches = Input.touches;
		if (touches.Length == 0) {
			return;
		}
		foreach (var t in touches) {
			if (touches.Length == 1) {
				string msg1 = "";
				if (t.position.x > Screen.width / 2) {
					msg1 = " 右半分 ";
				} else if (t.position.x < Screen.width / 2) {
					msg1 = " 左半分 ";
				}
		

			string msg2 = "";
			if (t.phase == TouchPhase.Began) {
				msg2 = "をタッチしました";
				Debug.Log (msg1 + msg2);
			} else if (t.phase == TouchPhase.Ended) {
				msg2 = "から指を離しました";
				Debug.Log (msg1 + msg2);
				}
				}
			}
		}
	}