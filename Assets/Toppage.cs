using UnityEngine;
using System.Collections;

public class Toppage : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void pressStart(){
		print ("a");
		Application.LoadLevel ("GameMain");
	}
}
