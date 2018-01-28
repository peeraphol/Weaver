using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour {

	private int currentPower = 100; 
  public int CurrentPower {
    get { return currentPower;}
    set { currentPower = value;}
  }
  private int totalGenRate = 0;
  public int TotalGenRate {
    get { return totalGenRate;}
    set { totalGenRate = value;}
  }
  private int maxUnit = 100;
  public int MaxUnit {
    get { return maxUnit;}
    set { maxUnit = value;}
  }
  private float currentPlanet = 0;
  public float CurrentPlanet {
    get { return currentPlanet;}
    set { currentPlanet = value;}
  }
  private float time = 0;
    public float Time {
    get { return time;}
    set { time = value;}
  }

  //All Stars Info
  private List<Star> starInfo = new List<Star>();
  private string[] starName = new string[]{ "Gaia", "Keen",
  "Odorous", "Khask", "Aon", "Zenon", "Glee", "Teoron", "Facas", "Yveva",
  "Ive", "GGJ", "Leon", "Samh", "Adhala", "Feonel", "Ki", "Jhaka", "Bumbala",
  "Dwadle", "Lissa", "Black", "Walr", "Konima", "White Whale" };
  private string[] starType = new string[]{ "Power", "Builder",
  "Power", "Power", "Power", "Power", "Builder", "Power", "Power", "Power",
  "Power", "Builder", "Power", "Power", "Power", "Builder", "Power", "Power", "Power",
  "Power", "Power", "Builder", "Power", "Power", "Power" };
  private int[] starHP = new int[]{ 1000, 350,
  350, 350, 350, 350, 350, 350, 350, 350,
  350, 350, 350, 350, 350, 350, 350, 350, 350,
  350, 350, 350, 350, 350, 350 };
  private int[] starGenerateRatePerSec = { 10, 0,
  10, 10, 10, 10, 0, 10, 10, 10,
  10, 0, 10, 10, 10, 0, 10, 10, 10,
  10, 10, 0, 10, 10, 10 };
  private int[] starMaxUnitCapacity = new int[]{ 10, 20,
  10, 10, 10, 10, 20, 10, 10, 10,
  10, 20, 10, 10, 10, 20, 10, 10, 10,
  10, 10, 20, 10, 10, 10 };
  private int[] starPrice = new int[]{ 0, 200,
  200, 200, 200, 200, 200, 200, 200, 250,
  500, 500, 500, 500, 500, 500, 500, 500, 500,
  500, 500, 500, 500, 500, 500 };

  public string getStarName(int index)
  {
    return starName[index];
  }
  public string getStarType(int index)
  {
    return starType[index];
  }
  public int getStarHP(int index)
  {
    return starHP[index];
  }
  public int getStarGenerateRatePerSec(int index)
  {
    return starGenerateRatePerSec[index];
  }
  public int getStarMaxUnitCapacity(int index)
  {
    return starMaxUnitCapacity[index];
  }
  public int getStarPrice(int index)
  {
    return starPrice[index];
  }

  private static ResourceManager instance;
  private ResourceManager() {}

  public static ResourceManager Instance{
    get
    {
      if(instance == null)
      {
        instance = GameObject.FindObjectOfType<ResourceManager>();
      }

      return instance;
    }
  }

  void Awake()
  {
    DontDestroyOnLoad(gameObject);
  }

  void Start(){
  }

  void Update(){
  }

  public bool buySomething(int price)
  {
    if(canBuy(price))
    {
      this.currentPower -= price;
      return true;
    }
    return false;
  }

  public bool canBuy(int price)
  {
    if(currentPower - price >= 0)
    {
      return true;
    }
    return false;
  }
}
