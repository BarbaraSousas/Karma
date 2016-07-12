using UnityEngine;
using System.Collections;

public class Controle_tela_menu : MonoBehaviour {
	public Camera cam;
	private static float minX;
	private static float maxX;
	private static float minY;
	private static float maxY;
	private static float Z;

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.Portrait;
		Z = transform.position.z - cam.transform.position.z;
		minX = cam.ScreenToWorldPoint (new Vector3 (0,0, Z)).x;
		minX = cam.ScreenToWorldPoint (new Vector3 (0,Screen.width, Z)).x;
		minY = cam.ScreenToWorldPoint (new Vector3 (0,0, Z)).y;
		minY = cam.ScreenToWorldPoint (new Vector3 (0,Screen.height, Z)).y;
	}

	// Update is called once per frame
	void Update () {

	}

	public static float MinX(){
		return minX;
	}
	public static float MaxX(){
		return maxX;
	}
	public static float MinY(){
		return minY;
	}
	public static float MaxY(){
		return maxY;
	}
}
