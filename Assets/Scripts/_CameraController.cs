using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _CameraController : MonoBehaviour {

	//public GameObject MainCamera;
	public GameObject CameraPivot;
	public GameObject Center;
	public Transform defaultPos;
	public Transform zoomPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (UnitBuilding.SelectedStar == null) {
			gameObject.transform.position = defaultPos.transform.position;
			gameObject.transform.rotation = defaultPos.transform.rotation;
		} else {
			CameraPivot.transform.position = UnitBuilding.SelectedStar.transform.position;
			gameObject.transform.position = zoomPos.transform.position;
			gameObject.transform.rotation = zoomPos.transform.rotation;
		}
	}

	public void DeselectStar(){
		UnitBuilding.SelectedStar = null;
		CameraPivot.transform.position = Center.transform.position;
	}
}
