using UnityEngine;
using System.Collections;

public class PasaEscena : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		Application.LoadLevel ("escena2");
	}
}
