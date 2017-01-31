using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public GameObject gunPrefab;
	public float velocity = 20.0f;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			GameObject gun = Instantiate(gunPrefab,
				transform.position,
				transform.rotation) as GameObject;

			Vector3 screenPoint = Input.mousePosition;
			screenPoint.z = 1.0f;

			Vector3 worldPoint = Camera.main.ScreenToWorldPoint(screenPoint);
			Vector3 direction = (worldPoint - transform.position).normalized;

			gun.GetComponent<Rigidbody>().velocity = direction * velocity;
		}
	}
}
