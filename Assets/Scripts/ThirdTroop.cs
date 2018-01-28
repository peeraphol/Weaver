using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdTroop : Troop {

  private Transform startMarker;
  public Transform endMarker;
  public float speed = 0.2f;
  private float startTime;
  private float journeyLength;
	
	public ThirdTroop(){
    this.TroopName = "Cruiser";
    this.Attack = 3;
  }

  void Start() {
    startTime = Time.time;
    this.startMarker = gameObject.transform;
    journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
  }
  void Update() {
    float distCovered = (Time.time - startTime) * speed;
    float fracJourney = distCovered / journeyLength;
    transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
  }
}
