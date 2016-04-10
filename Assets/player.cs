using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public GameObject barrior;
	bool canMove;
	
	public void SetMove(bool newValue)
	{
		canMove = newValue;
		if ((newValue == true) && (barrior != null))
			Destroy(barrior);
	}
	
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Bullet")
			Debug.Log("Hit by bullet");
    }
	
	// Use this for initialization
	void Start () {
		canMove = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (canMove)
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
