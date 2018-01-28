using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour {

  private string starName;
  private int nodePositionName;
  private int hp;
  private string troop;
  private string tower;
  private int shield;
  private int price;
  private int shieldRecharge;
  private int shieldPrice;
  
  public string StarName {
    get { return starName;}
    set { starName = value;}
  }
  public int NodePositionName {
    get { return nodePositionName;}
    set { nodePositionName = value;}
  }
  public int Hp {
    get { return hp;}
    set { hp = value;}
  }
  public string Troop {
    get { return troop; }
    set { troop = value; }
  }
  public string Tower {
    get { return tower;}
    set { tower = value;}
  }
  public int Shield {
    get { return shield;}
    set { shield = value;}
  }
  public int Price {
    get { return price; }
    set { price = value; }
  }
  public int ShieldRecharge {
    get { return shieldRecharge; }
    set { shieldRecharge = value; }
  }
  public int ShieldPrice {
    get { return shieldPrice; }
    set { shieldPrice = value; }
  }
}