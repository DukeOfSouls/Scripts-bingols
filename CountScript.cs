using UnityEngine;
using System.Collections;

public class CountScript : MonoBehaviour 
{
	public BingoScript BS;

	void Start()
	{
		BS = GameObject.Find("Main Camera").GetComponent<BingoScript>();
	}

	void OnTriggerEnter(Collider col)
	{
		BS.bingoCounter++;
        Debug.Log(BS.bingoCounter);
		Destroy(gameObject);
	}
}
