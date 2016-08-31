using UnityEngine;
using System.Collections;

public class EnemyCreator : MonoBehaviour {

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
		Sphere = (GameObject)Resources.Load ("Enemy");
		objShooter = GameObject.Find ("shooter");
		vec = new Vector3 (3,1,3);
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("p")) {
			GameObject objEnemy= (GameObject)Instantiate (Sphere,vec,Quaternion.identity);
			objEnemy.name = "ballet" + iShooter;
			iShooter++;
		}

	}
}
