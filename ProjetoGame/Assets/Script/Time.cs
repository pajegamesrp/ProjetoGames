using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Time : MonoBehaviour {

	int count = 0;
	public Text texto;

	// Use this for initialization
	void Start () {
		StartCoroutine (oneSecondtimer ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator oneSecondtimer()
	{
		while (1==1) {
			yield return new WaitForSeconds(1.0f);
			count++;
			texto.text = "Tempo : " + count.ToString();
		}
	}
}
