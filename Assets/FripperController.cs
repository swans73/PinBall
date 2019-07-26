using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour {
    private HingeJoint myHingeJoint;
    private float defaultAngle = 20;
    private float flickAngle = -20;

	// Use this for initialization
	void Start () {
        this.myHingeJoint = GetComponent<HingeJoint>();
        SetAngle(this.defaultAngle);

	}
	
	// Update is called once per frame
	void Update () {
		var touches = Input.touches;
		if (touches.Length == 0) {
			return;
		}
		foreach (var t in touches) {
			// タッチされた回数分ループする
				string msg1 = "";
				string msg2 = "";

				if (t.position.x > Screen.width / 2 && tag == "RightFripperTag") {
					SetAngle (this.flickAngle);
					msg1 = " 右半分 ";
					if (t.phase == TouchPhase.Began) {
						msg2 = "をタッチしました";
						Debug.Log (msg1 + msg2);
					} else if(t.phase == TouchPhase.Ended) {
						SetAngle (this.defaultAngle);
						msg2 = "から指を離しました";
						Debug.Log (msg1 + msg2);
					}


				} else if (t.position.x < Screen.width / 2 && tag == "LeftFripperTag") {
					SetAngle (this.flickAngle);
					msg1 = " 左半分 ";
					if (t.phase == TouchPhase.Began) {
						msg2 = "をタッチしました";
						Debug.Log (msg1 + msg2);
					} else if(t.phase == TouchPhase.Ended) {
						SetAngle (this.defaultAngle);
						msg2 = "から指を離しました";
						Debug.Log (msg1 + msg2);
					}
					}
				
				

					
					

			
		}
//		var position = Input.mousePosition;
//		if (Input.GetMouseButtonDown (0) && Input.mousePosition.x < Screen.width / 2 && tag == "LeftFripperTag") {
//			SetAngle (this.flickAngle);
//			Debug.Log ("L:" + position);
//		}
//		if (Input.GetMouseButtonDown (0) && Input.mousePosition.x > Screen.width / 2 && tag == "RightFripperTag") {
//			SetAngle (this.flickAngle);
//			Debug.Log ("R:" + position);
//		} 
//		if (Input.GetMouseButtonUp (0) && Input.mousePosition.x < Screen.width / 2 && tag == "LeftFripperTag") {
//			SetAngle (this.defaultAngle);
//		}
//		if (Input.GetMouseButtonUp (0) && Input.mousePosition.x > Screen.width / 2 && tag == "RightFripperTag") {
//			SetAngle (this.defaultAngle);
//		}
//		if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
//        {
//            SetAngle(this.flickAngle);
//        }
//		if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
//        {
//            SetAngle(this.flickAngle);
//        }
//        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag")
//        {
//            SetAngle(this.defaultAngle);
//        }
//        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag")
//        {
//            SetAngle(this.defaultAngle);
//        }
	}
    public void SetAngle (float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}
