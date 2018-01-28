using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleanim : MonoBehaviour {

	public Transform core;
	public GameObject chargeparticle;
	public GameObject minicharge;
	public GameObject Shockwave;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void charge()
	{
		Instantiate (chargeparticle, core.position, transform.rotation);

	}
	void shockwave()
	{
		Instantiate (Shockwave, core.position, transform.rotation);

	}
	void miniwave()
	{
		Instantiate (minicharge, core.position, transform.rotation);

	}
}
