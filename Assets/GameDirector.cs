using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {
	GameObject timerText;
	float time = 15.0f;

	private GameObject gameoverText;
	private GameObject pointText;
	public int point = 0;


	public void GetSmallStar() {
		this.point += 1;
	}

	public void GetLargeStar() {
		this.point += 10;
	}

	public void GetSmallCloud() {
		this.point += 50;
	}

	public void GetLargeCloud() {
		this.point += 100;
	}
	// Use this for initialization
	void Start () {
		this.timerText = GameObject.Find ("Time");
		this.pointText = GameObject.Find ("PointText");
		this.gameoverText = GameObject.Find ("GameOverText");

	}
	
	// Update is called once per frame
	void Update () {
		this.time -= Time.deltaTime;
		this.timerText.GetComponent<Text> ().text =
			this.time.ToString ("F1");
		if (this.time <= 0) {
			this.time = 0;
			this.gameoverText.GetComponent<Text>().text = "Time Up!";
		}
		this.pointText.GetComponent<Text>().text =
			this.point.ToString() + " point";
	}
}
