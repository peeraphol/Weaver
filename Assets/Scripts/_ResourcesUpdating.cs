using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _ResourcesUpdating : MonoBehaviour {

	private int nodeCount;
	private int curUnit;
	private int maxUnit;
	private int rechargeRate;
	private int curPower;

	public Text NodeCount;
	public Text UnitCapacity;
	public Text RechargeRate;
	public Text CurPower;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CurPower.text = ": " + ResourceManager.Instance.CurrentPower + " Units";
		RechargeRate.text = ResourceManager.Instance.TotalGenRate + " Units/sec";
		NodeCount.text = ResourceManager.Instance.CurrentPlanet + "";
		//UnitCapacity.text =  ResourceManager.Instance.MaxUnit + " ";

	//	ResourceManager rm = new ResourceManager ();
	//	rm.gameObject.GetComponent<ResourceManager>().
	}
}
