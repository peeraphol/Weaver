using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {
	
  private string turretName;
  private int hp;
	private int attack;

	public string TurretName {
    get { return turretName;}
    set { turretName = value;}
  }

	public int Hp {
    get { return hp;}
    set { hp = value;}
  }

	public int Attack {
    get { return attack;}
    set { attack = value;}
  }
}
