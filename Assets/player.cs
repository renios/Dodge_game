using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		MoveInputChecker();	
	}

	void MoveInputChecker ()
	{
		Vector3 direction = Vector3.zero;
		if (Input.GetKey(KeyCode.UpArrow))
			direction += Vector3.up;
		if (Input.GetKey(KeyCode.DownArrow))
			direction += Vector3.down;
		if (Input.GetKey(KeyCode.LeftArrow))
			direction += Vector3.left;
		if (Input.GetKey(KeyCode.RightArrow))
			direction += Vector3.right;
		
		transform.position += direction * 0.1f;
	}
}
