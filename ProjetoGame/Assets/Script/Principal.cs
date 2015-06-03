using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Principal : MonoBehaviour {

	public string conteudo = "";
	Text text;	

	// PEGA OS VALORES DA VARIALVE TEXT E JOGA EM Text
	void Awake () {
		text = GetComponent <Text> ();
	}

	// Use this for initialization
	void Start () {
		text.text = conteudo;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
