using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject bulletObject;
	public GameObject starBulletObject;
	public float constant = 0.5f;
	public float delay = 2;

	public void StartShotStarBullet()
	{
		StartCoroutine(ShotStarBullet());
	}

	IEnumerator ShotStarBullet()
	{
		while (true)
		{
			if (Random.Range(0, 2) != 0)
			{
				if (Random.Range(0, 2) != 0)
					Instantiate(starBulletObject, new Vector3(Random.Range(-5.7f, -5.7f), 3.5f, 0), Quaternion.identity);
				else
					Instantiate(starBulletObject, new Vector3(Random.Range(-5.7f, -5.7f), -3.5f, 0), Quaternion.identity);
			}
			else
			{
				if (Random.Range(0, 2) != 0)
					Instantiate(starBulletObject, new Vector3(5.7f, Random.Range(-3.5f, 3.5f), 0), Quaternion.identity);
				else
					Instantiate(starBulletObject, new Vector3(-5.7f, Random.Range(-3.5f, 3.5f), 0), Quaternion.identity);	
			}
			
			yield return new WaitForSeconds(delay);
		}
		yield return null;
	}

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
