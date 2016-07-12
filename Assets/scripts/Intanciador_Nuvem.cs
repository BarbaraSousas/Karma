using UnityEngine;
using System.Collections;

public class Intanciador_Nuvem : MonoBehaviour {

	private float maxSpawTime = 4;
	private float minSpawTime = 3;
	private float spawNuvem;
	private float randomY;
	private float randomZ;
	public GameObject nuvem;
	private bool instanciado;



	// Use this for initialization
	void Start () {
		StartCoroutine ("Instanciar");


	}

	// Update is called once per frame
	void Update () {


	}

	private IEnumerator Instanciar(){
		spawNuvem = Random.Range (minSpawTime, maxSpawTime);
		randomY = Random.Range (27.3f, 42f);
		randomZ = Random.Range (114.9f, 117.9f);
		yield return new WaitForSeconds (spawNuvem);
		nuvem = Instantiate( nuvem , new Vector3(transform.position.x,randomY, randomZ), Quaternion.Euler(0,0,0)) as GameObject;
		StartCoroutine ("Instanciar");
	}
}
