using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	public float maxMass;
	public float minMass;

	// Use this for initialization
	void Start () {
		Vector2 forceVector = Vector2.zero - (Vector2)transform.position;
		GetComponent<Rigidbody2D>().AddForce(forceVector, ForceMode2D.Force);
		
		GetComponent<Rigidbody2D>().mass = Random.Range(minMass, maxMass);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
