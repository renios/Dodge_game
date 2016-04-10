using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject bulletObject;
	public float constant = 0.5f;

	// Use this for initialization
	void Start () {
		for (float x = -5.7f; x <= 5.7f; x += constant)
		{
			Instantiate(bulletObject, new Vector3(x, 3.5f, 0), Quaternion.identity);
			Instantiate(bulletObject, new Vector3(x, -3.5f, 0), Quaternion.identity);
		}
		for (float y = -3.5f; y <= 3.5f; y += constant)
		{
			Instantiate(bulletObject, new Vector3(5.7f, y, 0), Quaternion.identity);
			Instantiate(bulletObject, new Vector3(-5.7f, y, 0), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
