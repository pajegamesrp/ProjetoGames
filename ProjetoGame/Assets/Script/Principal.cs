using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Principal : MonoBehaviour {

	public int tipo = 0;
	int count = 0;
	public Text texto = null;
	private int countPontos=0;
	Text ponto;
	Text text;

	// PEGA OS VALORES DA VARIALVE TEXT E JOGA EM Text
	void Awake () {
		text = GetComponent <Text> ();
	}

	// Use this for initialization
	void Start () {
		StartCoroutine (oneSecondtimer ());
	}
	
	// Update is called once per frame
	void Update () {
		/* Cronometo Time */
		if (tipo == 1) {
			text.text = texto.text;
		} else if (tipo == 2) { // usuario
			text.text = "Usuario : Gamer User";
		} else 
		{
			text.text = ponto.text;
		}
	}

	IEnumerator oneSecondtimer()
	{
		while (1==1) {
			yield return new WaitForSeconds(1.0f);
			count++;
			texto.text = "Tempo : " + count.ToString();
		}
	}
	void OnTriggerEnter(Collider other) 
	{

		if (other.gameObject.CompareTag ("Pontos"))
		{
				other.gameObject.SetActive(false);
				countPontos ++;
				ponto.text = "Pontos: " + countPontos.ToString ();
		}
	}


}
