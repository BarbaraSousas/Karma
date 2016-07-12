using UnityEngine;
using System.Collections;

public class Intaciador_carro : MonoBehaviour {

	private float maxSpawTime = 7;
	private float minSpawTime = 6;
	private float spawCarro;
	public GameObject carro;
	private bool instanciado;



	// Use this for initialization
	void Start () {
		StartCoroutine ("Instanciar");


	}

	// Update is called once per frame
	void Update () {


	}

	private IEnumerator Instanciar(){
		spawCarro = Random.Range (minSpawTime, maxSpawTime);
		yield return new WaitForSeconds (spawCarro);
		carro = Instantiate( carro , new Vector3(transform.position.x,transform.position.y, transform.position.z), Quaternion.Euler(0,0,0)) as GameObject;
		StartCoroutine ("Instanciar");
	}
}
