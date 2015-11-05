using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	void OnCollisionEnter(Collision col){
		Application.LoadLevel ("escenapunt");
	}
}
