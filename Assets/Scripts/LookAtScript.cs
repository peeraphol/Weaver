using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtScript : MonoBehaviour {

	private GameObject target;
	// Use this for initialization
	void Start () {
		target = GameObject.Find ("0");
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (target.transform);
	}
}
