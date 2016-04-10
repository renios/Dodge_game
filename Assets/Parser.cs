using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Parser : MonoBehaviour {

	public static List<DialogueData> GetParsedDialogueData(TextAsset dialogueDataFile)
	{
		List<DialogueData> dialogueDataList = new List<DialogueData>();
		
		string csvText = dialogueDataFile.text;
		string[] unparsedDialogueDataStrings = csvText.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
		
		for (int i = 0; i < unparsedDialogueDataStrings.Length; i++)
		{
			DialogueData dialogueData = new DialogueData(unparsedDialogueDataStrings[i]);
			dialogueDataList.Add(dialogueData);
		}
		
		return dialogueDataList;
	}
}