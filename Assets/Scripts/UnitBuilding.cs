using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitBuilding : MonoBehaviour {

	public GameObject uiGroup;
	public static GameObject SelectedStar;
	public GameObject[] unit;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (SelectedStar == null) {
			uiGroup.SetActive(false);
		} else {
			uiGroup.SetActive(true);
		}
	}


	public void buyingInterceptor(){
		if(ResourceManager.Instance.buySomething(10))
		{
			SelectedStar.GetComponent<_TroopsManager> ().interceptor++;
		//	Instantiate(unit[0]);
			print ("Spawn");
		}
	}
	public void buyingFighter(){
		if(ResourceManager.Instance.buySomething(30))
		{
			SelectedStar.GetComponent<_TroopsManager> ().fighter++;
		//	Instantiate(unit[1]);
		}
	}
	public void buyingCruiser(){
		if(ResourceManager.Instance.buySomething(50))
		{
			SelectedStar.GetComponent<_TroopsManager> ().cruiser++;
		//	Instantiate(unit[2]);
		}
	}
	public void buyingTurret(){
		if (SelectedStar.GetComponent<_TroopsManager> ().turret == 0 && SelectedStar.GetComponent<_TroopsManager> ().hTurret <= 0) {
			if (ResourceManager.Instance.buySomething (300)) {
				SelectedStar.GetComponent<_TroopsManager> ().turret++;
				SelectedStar.GetComponent<_TroopsManager> ().turretHP = 50;
		//		Instantiate (unit [3]);
			}
		}
	}
	public void buyingHeavyTurret(){
		if (SelectedStar.GetComponent<_TroopsManager> ().hTurret == 0 && SelectedStar.GetComponent<_TroopsManager> ().turret <= 0) {
			if (ResourceManager.Instance.buySomething (500)) {
				SelectedStar.GetComponent<_TroopsManager> ().hTurret++;
				SelectedStar.GetComponent<_TroopsManager> ().turretHP = 100;
		//		Instantiate (unit [4]);
			}
		}
	}
	public void buyingShieldGenerator(){
		if (SelectedStar.GetComponent<_TroopsManager> ().shieldGen == 0) {
			if (ResourceManager.Instance.buySomething (200)) {
				SelectedStar.GetComponent<_TroopsManager> ().shieldGen = 200;
		//		Instantiate (unit [5]);
			}
		}
	}
}
