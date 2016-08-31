using UnityEngine;
using System.Collections;

public class unitychan : MonoBehaviour {

	private Animator animator;
	private GameObject objMe;
	private GameObject objShooter;
	private Rigidbody rigMe;
	private int iShootMax = 100;
	private static int iShooter = 0;
	private GameObject Sphere;
	private Vector3 vec;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		objMe = gameObject;
		rigMe = objMe.GetComponent<Rigidbody>();
		Sphere = (GameObject)Resources.Load ("Sphere");
		objShooter = GameObject.Find ("shooter");
		vec = new Vector3 (5,0,3);
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && iShooter <= iShootMax) {
			iShooter++;
			GameObject objballet = (GameObject)Instantiate (Sphere,objShooter.transform.position,Quaternion.identity);
			objballet.name = "ballet" + iShooter;
			Rigidbody rigBallet = objballet.GetComponent<Rigidbody>();
			rigBallet.AddForce (objShooter.transform.forward * 3000);
		}

		if (Input.GetMouseButtonDown (1) && iShooter >= iShootMax) {
			iShooter = 0;
		}
		if (Input.GetKey ("w")) {
			transform.position += transform.forward * 0.1f;
		}
		if (Input.GetKey ("s")) {
			transform.position -= transform.forward * 0.1f;
		}
		if (Input.GetKey ("d")) {
			transform.Rotate (0, 10, 0);
		}
		if (Input.GetKey ("a")) {
			transform.Rotate (0, -10, 0);
		}
		transform.rotation = new Quaternion (0, gameObject.transform.position.y, gameObject.transform.position.z,0);


		if (Input.GetKeyDown ("space")) {
			rigMe.AddForce (0,50000,0);
		}
	}
}
