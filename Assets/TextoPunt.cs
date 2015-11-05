using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TextoPunt : MonoBehaviour {

	public GameObject t1;
	public GameObject t2;

	// Use this for initialization
	void Start () {

		Text texto1 = t1.GetComponent<Text> ();
		Text texto2 = t2.GetComponent<Text> ();

		texto1.text = "Tu puntuacion es: " + PlayerPrefs.GetInt ("GameManager").ToString();
		if(PlayerPrefs.GetInt("Puntuacion") < PlayerPrefs.GetInt("GameManager")){
			PlayerPrefs.SetInt("Puntuacion",PlayerPrefs.GetInt("GameManager"));
	    }
		PlayerPrefs.SetInt ("GameManager", 0);
		texto2.text = "La puntuacion maxima es: " + PlayerPrefs.GetInt ("Puntuacion").ToString ();
	}
	
	// Update is called once per frame
	void Update () {

	}
}
