using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEnemy : Enemy {

  public Transform startMarker;
  public Transform endMarker;
  public float speed = 0.2f;
  private float startTime;
  private float journeyLength;
  public Vector3 spawnLocation = new Vector3(0,2,0);
  public GameObject dummy;
 // public bool isTurret;

	public _TroopsManager target;

  public SEnemy() {
    this.EnemyName = "Small";
    this.Hp = 10;
    this.Attack = 2;
  }

  void Start() {
    startTime = Time.time;
    this.startMarker = gameObject.transform;
    this.endMarker = GameObject.Find("0").transform; /////////////////////////////////////////////////////////// ##########   0 is the name of head planet
    journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
  }
  void Update() {
    float distCovered = (Time.time - startTime) * speed;
    float fracJourney = distCovered / journeyLength;
    transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
		if (this.Hp <= 0) {
			Destroy (gameObject, 0.01f);
		}
  }

   void OnTriggerEnter(Collider collider){ //check box star
		if(collider.tag == "star" && collider.GetComponent<Node>().isBuy == true){
       	speed = 0;
			//endMarker = collider.gameObject.transform;
			target = collider.GetComponent<_TroopsManager>();
			InvokeRepeating ("DamageCalculator", 0.1f, 0.2f);
			//Damage Calculation here
		}
	}

	public void DamageCalculator(){
		if (target.interceptor > 0){
			this.Hp -= 1;
			target.interceptor--;
		}
		if (target.interceptor == 0 && target.fighter > 0){
			this.Hp -= 2;
			target.fighter--;
		}
		if (target.interceptor == 0 && target.fighter == 0 && target.cruiser > 0) {
			this.Hp -= 3;
			target.cruiser--;
		}
		if (target.interceptor == 0 && target.fighter == 0 && target.cruiser == 0 && target.turretHP > 0) {
			if (target.turret == 1) {
				this.Hp -= 2;
				target.turretHP -= this.Attack;
			}
			if (target.hTurret == 1) {
				this.Hp -= 4;
				target.turretHP -= this.Attack;
			}
		}
		if (target.turretHP == 0 && (target.turret == 1 || target.hTurret == 1)){
			target.turret = 0;
			target.hTurret = 0;
		}
		if (target.interceptor == 0 && target.fighter == 0 && target.cruiser == 0 && target.turretHP == 0 && target.shieldGen > 0) {
			target.shieldGen -= this.Attack;
		}
		if (target.interceptor == 0 && target.fighter == 0 && target.cruiser == 0 && target.turretHP == 0 && target.shieldGen == 0) {
			if (target.gameObject.GetComponent<PowerStar> ()) {
				target.gameObject.GetComponent<PowerStar> ().Hp -= this.Attack;
				Debug.Log (target.gameObject.GetComponent<PowerStar> ().Hp);
				if (target.gameObject.GetComponent<PowerStar> ().Hp <= 0) {
					speed = 1;
					startTime = Time.time;
					journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
					CancelInvoke();
				}
			}
			if (target.gameObject.GetComponent<BuilderStar> ()) {
				target.gameObject.GetComponent<BuilderStar> ().Hp -= this.Attack;
				Debug.Log (target.gameObject.GetComponent<BuilderStar> ().Hp);
				if (target.gameObject.GetComponent<BuilderStar> ().Hp <= 0) {
					speed = 1;
					startTime = Time.time;
					journeyLength = Vector3.Distance (startMarker.position, endMarker.position);
					CancelInvoke ();
				}
			}
		}

	}
  //     endMarker = collider.gameObject.transform;
  //     // Instantiate(dummy,collider.gameObject.transform.position,Quaternion.identity);
  //   } else if(collider.gameObject.tag == "trooper"){
  //     this.Hp -= collider.gameObject.GetComponent<FirstTroop>().Attack;
  //     Destroy(collider.gameObject);
  //     Debug.Log("Enemy HP = " + this.Hp);
  //   }
  // }

  // void OnTriggerStay(Collider collider){ //ลบเลือด turret
    // if (collider.tag == "star" && collider.gameObject.GetComponent<PowerStar>().TurrectHP > 0){
    //   collider.gameObject.GetComponent<PowerStar>().TurrectHP -= Attack;
    //   // Debug.Log("Turret HP = " +collider.gameObject.GetComponent<PowerStar>().TurrectHP);
    // }
    // if (collider.gameObject.GetComponent<PowerStar>().turret != null && collider.gameObject.GetComponent<PowerStar>().turret.name == "Turret" && collider.gameObject.GetComponent<PowerStar>().TurrectHP > 0){
    //   this.Hp -= collider.gameObject.GetComponent<PowerStar>().TurretAttack;
    //   Debug.Log(Hp);
    // }

    // if(collider.gameObject.GetComponent<PowerStar>().turret != null && collider.gameObject.GetComponent<PowerStar>().turret.name == "Heavy Turret" && collider.gameObject.GetComponent<PowerStar>().TurrectHP > 0){
    //   this.Hp -= collider.gameObject.GetComponent<PowerStar>().TurretAttack;
    //   Debug.Log(Hp);
    // }
  // }

/*  void DamageCalculator(Collider collider){
    if (collider.tag == "star"){
      speed = 0;

      if(isTurret){
        // if(collider.gameObject.name = "PowerStar"){

        // }
        // Hp -= collider.gameObject.GetComponent<PowerStar>().turret.GetComponent<FirstTurret>().Attack;
        // Debug.Log(collider.gameObject.GetComponent<Turret>().ToString());
        Debug.Log(collider.gameObject.name);
      }

    }
  }*/

 /* void OnTriggerStay(Collider star){
    isTurret = true;
  //  DamageCalculator(star);
    if (star.gameObject.GetComponent<Turret>().Hp == 0){
      Destroy(star.gameObject);
    }
  }*/


}
