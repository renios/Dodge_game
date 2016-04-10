﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Sprite jhj_sprite;
	public Sprite orchid_sprite;

	Player player;
	GameObject dialoguePanel;
	Image portraitImage;
	Text dialogueText;

	IEnumerator StartEvent()
	{
		dialoguePanel.SetActive(true);
		portraitImage.sprite = jhj_sprite;
		dialogueText.text = "처음 한 번은 역시 깔끔하게 반사!";
		yield return new WaitForSeconds(2.3f);

		dialogueText.text = "자, 이제 움직여볼까?";
		player.SetMove(true);
		yield return new WaitForSeconds(2f);

		portraitImage.sprite = orchid_sprite;
		dialogueText.text = "(박수)";
		yield return new WaitForSeconds(2f);
		dialoguePanel.SetActive(false);
	}
	
	IEnumerator BulletEvent()
	{
		dialoguePanel.SetActive(true);
		portraitImage.sprite = orchid_sprite;
		dialogueText.text = "그럼 슬슬 알갱이를 더 추가해보죠.";
		
		yield return new WaitForSeconds(2f);
		portraitImage.sprite = jhj_sprite;
		dialogueText.text = "어? 뭐라고? 잠깐, 잠깐!!";
		
		yield return new WaitForSeconds(2f);
		dialoguePanel.SetActive(false);
	}

	// Use this for initialization
	IEnumerator Start () {
		player = FindObjectOfType<Player>();
		dialoguePanel = GameObject.Find("DialoguePanel");
		portraitImage = GameObject.Find("Portrait").GetComponent<Image>();
		dialogueText = GameObject.Find("DialogueText").GetComponent<Text>();
		
		dialoguePanel.SetActive(false);
		
		yield return StartCoroutine(StartEvent());
		
		yield return new WaitForSeconds(5);
		
		StartCoroutine(BulletEvent());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}