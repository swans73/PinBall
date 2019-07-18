using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {
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
		this.pointText = GameObject.Find ("PointText");
	}
	
	// Update is called once per frame
	void Update () {
		this.pointText.GetComponent<Text>().text =
			this.point.ToString() + " point";
	}
}
