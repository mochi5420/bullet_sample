using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collisionInfo)
	{
		if(collisionInfo.gameObject.tag == "BOX")
		{
			//Destroy (Box)
			Destroy(collisionInfo.gameObject);

		}

		//Destroy (Bullet)
		Destroy(gameObject);
		
	}
}
