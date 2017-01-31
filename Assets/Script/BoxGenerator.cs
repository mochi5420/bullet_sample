using UnityEngine;
using System.Collections;

public class BoxGenerator : MonoBehaviour {

    public float interval = 1.5f;
    public GameObject boxPrefab = null;

    private bool nextIsRed;
    private float timer;

	// Use this for initialization
	void Start () {
        timer = 0;
        nextIsRed = true;
	
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if(timer < 0){

            float offsX = Random.Range(-4.0f, 4.0f);
            float offsZ = Random.Range(-2.0f, 2.0f);

            Vector3 position = transform.position + new Vector3(offsX, 0, offsZ);

            Instantiate(boxPrefab, position, Random.rotation);

            nextIsRed = !nextIsRed;

            timer = interval; 
        
        }
	
	}
}
