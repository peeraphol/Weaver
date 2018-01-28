using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _TroopsManager : MonoBehaviour {

	public int interceptor;
	public int fighter;
	public int cruiser;
	public int turret;
	public int hTurret;
	public int turretHP;
	public int shieldGen;

	public Text[] troopsNumber;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (UnitBuilding.SelectedStar == gameObject) {
			troopsNumber [0].text = "" + interceptor;
			troopsNumber [1].text = "" + fighter;
			troopsNumber [2].text = "" + cruiser;
			troopsNumber [3].text = "" + turret;
			troopsNumber [4].text = "" + hTurret;
			troopsNumber [5].text = "" + shieldGen;
		}
	}
}
