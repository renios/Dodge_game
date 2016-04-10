﻿using UnityEngine;
using System.Collections;

public enum DataType
{
	
}

public class DialogueData{

	bool isEffect;
	string nameInCode;
	string emotion;
	string name;
	string dialogue;
	
	string effectType;
	string effectSubType;
	
	public bool IsEffect() { return isEffect; }
	public string GetNameInCode() { return nameInCode; }
	public string GetEmotion() { return nameInCode; }
	public string GetName() { return name; }
	public string GetDialogue() { return dialogue; }
	public string GetEffectType() { return effectType; }
	public string GetEffectSubType() { return effectSubType; }
	
	public DialogueData (string unparsedDialogueDataString)
	{
		string[] stringList = unparsedDialogueDataString.Split('\t');
		
		if (stringList[0] == "*") // effects.
		{
			isEffect = true;
			effectType = stringList[1];
			if (effectType == "appear")
			{
				effectSubType = stringList[2];
				nameInCode = stringList[3];
			}
			else if (effectType == "disappear")
			{
				effectSubType = stringList[2];
			}
			else
			{
				Debug.LogError("undefined effectType : " + stringList[1]);
			}
		}
		else
		{
			isEffect = false;
			nameInCode = stringList[0];
			emotion = stringList[1];
			name = stringList[2];
			dialogue = stringList[3];
		}
	}
}
