using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeController : MonoBehaviour {

	private List<Node> nodes;
	public Transform planets;

	private List<Edge> edges;
	public Transform lines;

  private static NodeController instance;
  private NodeController() {}

  public static NodeController Instance{
    get
    {
      if(instance == null)
      {
        instance = GameObject.FindObjectOfType<NodeController>();
      }

      return instance;
    }
  }

  void Awake()
  {
    DontDestroyOnLoad(gameObject);
  }

	// Use this for initialization
	void Start () {
		//Init node
		nodes = new List<Node>();
		foreach(Transform child in planets)
		{
			nodes.Add(child.GetComponent<Node>());
		}
		//Init edge
		edges = new List<Edge>();
		foreach(Transform child in lines)
		{
			edges.Add(child.GetComponent<Edge>());
		}
		InvokeRepeating("updateStarInfo",0,1);
	}
	
	// Update is called once per frame
	void Update () {
		for(int i=0; i<edges.Count; i++)
		{
			bool isFirstNodeBuy = nodes[edges[i].connect[0]].isBuy;
			bool isSecondNodeBuy = nodes[edges[i].connect[1]].isBuy;
			if(isFirstNodeBuy && isSecondNodeBuy)
			{
				edges[i].isLink = true;
				// Debug.Log("edges[" + i + "] : link");
			}
			else
			{
				edges[i].isLink = false;
			}
		}
	}

	public bool buyPlanet(int nodeId)
	{
		int[] connect = nodes[nodeId].connect;
		bool isConnectPlanetIsBuy = false;
		//Check this plannet can buy or not
		for(int i=0; i<connect.Length; i++)
		{
			if(nodes[connect[i]].isBuy)
			{
				isConnectPlanetIsBuy = true;
			}
		}
		if(isConnectPlanetIsBuy)
		{
			nodes[nodeId].isBuy = true;
			return true;
		}
		return false;
	}

	public void updateStarInfo()
	{
		ResourceManager.Instance.TotalGenRate = 0;
		ResourceManager.Instance.MaxUnit = 100;
		ResourceManager.Instance.CurrentPlanet = 100;
		for(int i=0; i<nodes.Count; i++)
		{
			if(nodes[i].isBuy)
			{
				//Update Power total and gen rate
				ResourceManager.Instance.CurrentPower += ResourceManager.Instance.getStarGenerateRatePerSec(i);
				ResourceManager.Instance.TotalGenRate += ResourceManager.Instance.getStarGenerateRatePerSec(i);
				//Update MaxUnit
				ResourceManager.Instance.MaxUnit += ResourceManager.Instance.getStarMaxUnitCapacity(i);
				//Update CurrentPlanet
				ResourceManager.Instance.CurrentPlanet++; 
			}
		}
	}
}
