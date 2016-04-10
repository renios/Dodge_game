using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreChecker : MonoBehaviour {

	Text scoreText;
	float score;

	// Use this for initialization
	void Start () {
		scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		score += Time.deltaTime*2;
		
		scoreText.text = "Score : " + (int)score;
	}
}
