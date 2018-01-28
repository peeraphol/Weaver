using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	public GameObject obj;
	public Node node;

	public GameObject CameraController;
	public GameObject MainCamera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		//If bought, select the star instead of buying
		if (node.isBuy) {
			UnitBuilding.SelectedStar = gameObject;
		/*	if (UnitBuilding.SelectedStar != null) {
				
			} else {
				Unit
			}*/
		} else {
			//Buying System
			if (node.buy ()) {
				// Instantiate(obj);
				Debug.Log ("Buy");
			}
			Debug.Log ("Cannnot Buy");
		}  
	}
}