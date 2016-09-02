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
    private GameObject objCamera;
    private Transform transCamera;

    private Vector3 vec;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		objMe = gameObject;
        objCamera = GameObject.Find("MainCamera");
        rigMe = objMe.GetComponent<Rigidbody>();
		Sphere = (GameObject)Resources.Load ("Sphere");
        transCamera = objCamera.GetComponent<Transform>();
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
			rigBallet.AddForce (objShooter.transform.forward.x * 3000,1000, objShooter.transform.forward.z*3000);
		}

		if (Input.GetMouseButtonDown (1) && iShooter >= iShootMax) {
			iShooter = 0;
		}
		if (Input.GetKey ("w")) {
			transform.position += transform.forward * 0.3f;
//            transCamera.position = transCamera.position + transform.forward * 0.3f;

        }
		if (Input.GetKey ("s")) {
			transform.position -= transform.forward * 0.3f;
//            transCamera.position = transCamera.position - transform.forward * 0.3f;

        }
        if (Input.GetKey ("d")) {
			transform.Rotate (0, 5, 0);
		}
		if (Input.GetKey ("a")) {
			transform.Rotate (0, -5, 0);
		}

        /*
        if (Input.GetKey("g"))
        {
            transCamera.Rotate(0, 5, 0);
        }
        if (Input.GetKey("j"))
        {
            transCamera.Rotate(0, -5, 0);
        }


        if (Input.GetKey("y"))
        {
            transCamera.position = transCamera.position + transCamera.forward * 0.3f;
        }
        if (Input.GetKey("h"))
        {
            transCamera.position = transCamera.position - transCamera.forward * 0.3f;
        }

    */
        //		transform.rotation = new Quaternion (0, gameObject.transform.position.y, gameObject.transform.position.z,0);


        if (Input.GetKeyDown ("space")) {
			rigMe.AddForce (0,50000,0);
		}
	}
}
