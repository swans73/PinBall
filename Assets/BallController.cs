using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {
    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;
	GameObject director;

	// Use this for initialization
	void Start () {
		this.director = GameObject.Find ("GameDirector");
        this.gameoverText = GameObject.Find("GameOverText");
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "SmallStarTag") {
			this.director.GetComponent<GameDirector>().GetSmallStar();
			Debug.Log ("SmallStar");
		} else if (other.gameObject.tag == "LargeStarTag") {
			this.director.GetComponent<GameDirector>().GetLargeStar();
			Debug.Log ("LargeStar");
		} else if (other.gameObject.tag == "SmallCloudTag") {
			this.director.GetComponent<GameDirector>().GetSmallCloud();
			Debug.Log ("SmallCloud");
		} else if (other.gameObject.tag == "LargeCloudTag") {
			this.director.GetComponent<GameDirector>().GetLargeCloud();
			Debug.Log ("LargeCloud");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
	}
}
