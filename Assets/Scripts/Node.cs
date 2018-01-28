using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour {

  public int nodeId;
  public int[] connect;
  public int[] line;
  public bool isBuy;

  public bool buy(){
    //Check have enough power to buy
		if (gameObject.tag == "star") {
			if (ResourceManager.Instance.canBuy (ResourceManager.Instance.getStarPrice (nodeId))) {
				//check planet can buy or not
				if (NodeController.Instance.buyPlanet (nodeId)) {
					//update power
					if (ResourceManager.Instance.buySomething (ResourceManager.Instance.getStarPrice (nodeId))) {
						return true;
					}
				}
			}
		}
    return false;
  }
}