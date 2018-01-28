using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	private string enemyName;
  private int hp;
  private int attack;

  public string EnemyName {
    get { return enemyName; }
    set { enemyName = value; }
  }
  public int Hp {
    get { return hp; }
    set { hp = value; }
  }
  public int Attack {
    get { return attack; }
    set { attack = value; }
  }
}
