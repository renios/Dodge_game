using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector2 forceVector = Vector2.zero - (Vector2)transform.position;
		GetComponent<Rigidbody2D>().AddForce(forceVector, ForceMode2D.Force);
		
		GetComponent<Rigidbody2D>().mass = Random.Range(0.03f, 0.04f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
