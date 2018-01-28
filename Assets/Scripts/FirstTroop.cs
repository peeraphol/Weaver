using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTroop : Troop {

  private Transform startMarker;
  public Transform endMarker;
  public float speed = 0.2f;
  private float startTime;
  private float journeyLength;

  public FirstTroop() {
    this.TroopName = "Intercepter";
    this.Attack = 1;
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
