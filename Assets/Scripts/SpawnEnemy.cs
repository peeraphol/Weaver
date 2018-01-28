using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

  public GameObject[] spawnPoint;
  public GameObject enemy_small;
  public GameObject enemy_medium;
  public GameObject enemy_large;
  public GameObject enemy_boss;
  private float i = 1.0f;

	void Start () {
		i += 30;
    /* WAVE #1 */
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;  
      i += 10;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;

    /* WAVE #2 */ i += 30;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
      i += 10;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
      i += 10;
    Invoke("Medium", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;

    /* WAVE #3 */ i += 30;
    Invoke("Medium", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
      i += 10;
    Invoke("Medium", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
      i += 10;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Large", i); i += 0.5f;

    /* WAVE #4 */ i += 30;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Medium", i); i += 0.5f;
      i += 10;
    Invoke("Medium", i); i += 0.5f;
    Invoke("Medium", i); i += 0.5f;
      i += 10;
    Invoke("Medium", i); i += 0.5f;
    Invoke("Medium", i); i += 0.5f;
    Invoke("Large", i); i += 0.5f;

    /* WAVE #5 */ i += 30;
    Invoke("Medium", i); i += 0.5f;
    Invoke("Medium", i); i += 0.5f;
      i += 10;
    Invoke("Large", i); i += 0.5f;
    Invoke("Medium", i); i += 0.5f;
    Invoke("Medium", i); i += 0.5f;
      i += 10;
    Invoke("Large", i); i += 0.5f;
    Invoke("Large", i); i += 0.5f;
    Invoke("Medium", i); i += 0.5f;
    Invoke("Medium", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
      i += 10;
    Invoke("Large", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Medium", i); i += 0.5f;

    /* WAVE #6 */ i += 30;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
      i += 10;
    Invoke("Medium", i); i += 0.5f;
    Invoke("Medium", i); i += 0.5f;
    Invoke("Large", i); i += 0.5f;
    Invoke("Large", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
      i += 10;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Medium", i); i += 0.5f;
    Invoke("Medium", i); i += 0.5f;
    Invoke("Medium", i); i += 0.5f;
    Invoke("Large", i); i += 0.5f;
    Invoke("Large", i); i += 0.5f;
      i += 10;
    Invoke("Boss", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Small", i); i += 0.5f;
    Invoke("Medium", i); i += 0.5f;
    Invoke("Medium", i); i += 0.5f;
    Invoke("Large", i); i += 0.5f;
  }

  void Small() {
    Instantiate (enemy_small, spawnPoint[Random.Range(0, spawnPoint.Length)].transform.position, Quaternion.identity);
    i = i + 0.5f;
  }
  void Medium() {
    Instantiate (enemy_medium, spawnPoint[Random.Range(0, spawnPoint.Length)].transform.position, Quaternion.identity);
    i = i + 0.5f;
  }
  void Large() {
    Instantiate (enemy_large, spawnPoint[Random.Range(0, spawnPoint.Length)].transform.position, Quaternion.identity);
    i = i + 0.5f;
  }
  void Boss() {
    Instantiate (enemy_boss, spawnPoint[Random.Range(0, spawnPoint.Length)].transform.position, Quaternion.identity);
    i = i + 0.5f;
  }
}
