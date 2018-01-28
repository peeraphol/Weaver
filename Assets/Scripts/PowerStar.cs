using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerStar : Star {

  public GameObject turret;
//	public Collider colTest;
  public PowerStar(){

    this.Shield = 100;
    
  }

  private int generateRate;
   private int turretAttack;
  private int turrectHP;
  
  public int GenerateRate {
    get { return generateRate; }
    set { generateRate = value; }
  }

  public int getPrice()
  {
    return this.Price;
  }
  public int TurretAttack {
    get { return turretAttack; }
    set { turretAttack = value; }
  }
  public int TurrectHP {
    get { return turrectHP; }
    set { turrectHP = value; }
  }
	void Start(){
		this.Hp = ResourceManager.Instance.getStarHP(gameObject.GetComponent<Node>().nodeId);
		this.Price = ResourceManager.Instance.getStarPrice(gameObject.GetComponent<Node>().nodeId);
	}
	void Update(){
		if (this.Hp == 0) {
			gameObject.GetComponent<Node> ().isBuy = false;
			gameObject.tag = "Untagged";
		}
		if (gameObject.GetComponent<Node> ().isBuy == false) {
			gameObject.GetComponent<Collider> ().enabled = false;
		}

	}

	/*
  void OnTriggerStay(Collider collider){ //check box star
    if(collider.gameObject.tag == "enemy" && turret != null){
      if (turret.gameObject.GetComponent<FirstTurret>().Hp > 0){
        turret.gameObject.GetComponent<FirstTurret>().Hp -= collider.gameObject.GetComponent<SEnemy>().Attack;
      } else if(Shield > 0){
        this.Shield -= collider.gameObject.GetComponent<SEnemy>().Attack;
      } else if (Hp > 0){
        this.Hp -= collider.gameObject.GetComponent<SEnemy>().Attack;
      }
    }
  }
  
  void OnTriggerEnter(Collider collider){
    if(turret != null){
      TurrectHP = turret.gameObject.GetComponent<FirstTurret>().Hp;
      TurretAttack = turret.gameObject.GetComponent<FirstTurret>().Attack;
    }
  }

  void Update(){
    if(turrectHP == 0){
      Destroy(turret);
      turret = null;
    }
  }*/
}
