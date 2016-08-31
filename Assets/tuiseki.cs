using UnityEngine;
using System.Collections;

public class tuiseki : MonoBehaviour {

	private Animator animator;
	private GameObject objMe;
	private GameObject objTarget;
	private Vector3 vec3Me;
	private float accelarator;
	private Rigidbody rigMe;
	private GameObject objDest;
	// Use this for initialization
	void Start () {
		objMe = gameObject;
		objTarget = GameObject.Find("Me");
		rigMe = objMe.GetComponent<Rigidbody>();
		accelarator = 10f;
		objDest = GameObject.Find ("destroyer");
	}

	// Update is called once per frame
	void Update () {
		vec3Me = objTarget.transform.position - objMe.transform.position;
		vec3Me.Normalize ();
		rigMe.AddForce (accelarator * vec3Me,ForceMode.Acceleration);
	}


	void OnCollisionEnter(Collision coll) {

	}
}