using UnityEngine;
using System.Collections;

public class NextScene : MonoBehaviour {
	void OnCollisionEnter(Collision col){
		Application.LoadLevel ("escena2");
	}
}
