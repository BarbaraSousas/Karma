using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Stamina : MonoBehaviour {


	public GameObject barraStamina;
	public float StaminaAtual = 0f;
	public float StaminaMaxima = 100f;
	public float calculaStamina = 0f;
	Text oTextoDaXP;
	public GameObject objetoText;
	float quantidadeExp = 0;
    public Button[] buttons;
    public Sprite[] images;

    public Sprite CorNegraBotao;

    //Variavel CoolDown que será alterada pelo button
    float coolDown = 0f;

    //Componente Imagem do botão
    Image aImagemDoBotao;

    //Sprite Inicial do botão
    Sprite spriteDefault;

    //bool para não da conflito nos botões
   // bool contando = false;



    //roda assim que instanciar
    void Start () {
		StaminaAtual = StaminaMaxima;
		Debug.Log (barraStamina.GetComponent<Image> ().fillAmount);
	}
	
	// Update is called once per frame

	void Update () {
		//a cada frame é chamado o decremento da stamina (remove com o tempo)
		if (barraStamina.GetComponent<Image> ().fillAmount > 0) {
            StartCoroutine(AguardaDecrementarStamina(150f)); 
			
		}
			


		//a cada frame é chamado o decremento da stamina (remove com o tempo)
		//StartCoroutine (DecrementaStaminaComTempo());

	}

	public void DecrementaStamina(float Valor)
	{
		// decremento já funciona
		if (barraStamina.GetComponent<Image>().fillAmount > 0 && Valor <= StaminaAtual) {

            //imprime a stamina atual
            //Debug.Log (StaminaAtual);

            //decremeta a stamina com o valor do botão
            
                StaminaAtual -= Valor;

                //calcula a stamina com dois zeros a esquerda.
                calculaStamina = StaminaAtual / StaminaMaxima;

                //Altera a stamina
                SetStamina(calculaStamina);
            
			
		} else 
		{
			Debug.Log ("Sem Stamina Suficiente");
			barraStamina.GetComponent<Image> ().fillAmount = 0;
		}
	}

    IEnumerator AguardaDecrementarStamina(float tempo)
    {
        yield return new WaitForSeconds(tempo * Time.deltaTime);
        DecrementaStamina(000000000000000000000000000000000000000000000000.1f);
    }

	//Implementar depois
	/*IEnumerator DecrementaStaminaComTempo ()
	{
		//aqui é onde contamos a diminuição e o tempo da stamina
		while (barraStamina.GetComponent<Image>().fillAmount > 0) 
		{
			//valor da stamina
			DecrementaStamina (decrementoNoTempo);

			//tempo
			yield return new WaitForSeconds(10f * Time.deltaTime);

			//acrescimo na remoção
			decrementoNoTempo += 0.0000000000000001f;


		}
	}*/


	public void SetStamina(float Valor)
	{		
		
		//Debug.Log ("Valor: " + Valor + "Stamina atual" + StaminaAtual);

		//Muda a barra da stamina
		//barraStamina.transform.localScale = new Vector3 (Valor,barraStamina.transform.localScale.y,barraStamina.transform.localScale.z);
		Image aImagem = barraStamina.GetComponent<Image>();
		if (Valor > 0) {
			aImagem.fillAmount = Valor;
		}

	}

	public void IncrementaXP(float Valor)
	{
		if (barraStamina.GetComponent<Image>().fillAmount > 0) {
			oTextoDaXP = objetoText.GetComponent<Text>();
			quantidadeExp += Valor;
			oTextoDaXP.text = quantidadeExp.ToString();
			Debug.Log (barraStamina.GetComponent<Image>().fillAmount);
		}


	}

    public void mudaImageButton(int pos)
    {
        //só entra no if se o contador do tempo tiver acabado
        //if (contando == false)
        //{
        //contando = true quer dizer que o contador vai começar a contar
        //contando = true;

        //o sprite original do botão
        /*spriteDefault = oBotao.image.sprite;

        //coloca a cor negra no botão que usou o metodo
        oBotao.image.sprite = CorNegraBotao;
        oBotao.enabled = false;
        //inicia o contador de fato
        StartCoroutine(ContaCoolDown(oBotao));
        */
        buttons[pos].image.sprite = CorNegraBotao;
        buttons[pos].enabled = false;
        StartCoroutine(ContaCoolDown(pos));

        //}




    }

    //Metodo para contar o coolDown
    public void SetCoolDown(float oCoolDown)
    {
        //if (contando == false)
        //{
        this.coolDown = oCoolDown;
        //}
    }

    //public void CD(GameObject oGameobj)
    //{

        //Button obotao = oGameobj.GetComponent<Button>();
        //mudaImageButton(obotao);
    //}

    IEnumerator ContaCoolDown(int pos)
    {
        //Conta os segundos recebido pelo metodo set cooldown
        yield return new WaitForSeconds(coolDown );
        //Debug.Log (Time.deltaTime);
        buttons[pos].image.sprite = images[pos];
        buttons[pos].enabled = true;
        //contando = false;
    }


}
