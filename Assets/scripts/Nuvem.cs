using UnityEngine;
using System.Collections;

public class Nuvem : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = new Vector3 (gameObject.transform.position.x + 0.15f, gameObject.transform.position.y, gameObject.transform.position.z);
		Remover ();
	}

	private void Remover(){
		if ( gameObject.transform.position.x > 58.2f) {
			Destroy (gameObject);
		} 
	} 
}
