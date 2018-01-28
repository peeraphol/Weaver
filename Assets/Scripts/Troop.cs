using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troop : MonoBehaviour {

  private string troopName;
  private int attack;

  public string TroopName {
    get { return troopName;}
    set { troopName = value;}
  }
  public int Attack {
    get { return attack;; }
    set { attack = value; }
  }
}
