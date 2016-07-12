using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mensagem : MonoBehaviour {
	public GameObject texto_mensagem;
	private string[] textos = {
		"Olá à equipe de desenvolvimento do Karma deseja a todos um bom relaxamento, lembre-se não pratique nem um mau com o proximo apenas deixe que o Karma cuidara de pessoas ruins. "
	};

	// Use this for initialization
	void Start () {
		Text meu_texto = texto_mensagem.GetComponent<Text> ();
		System.Random r = new System.Random ();
		int index = r.Next (0, textos.Length);
		meu_texto.text = textos [index];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
