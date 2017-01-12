using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GoldScript : MonoBehaviour 
{
	public TextMesh coinsTM;
	public TextMesh ticketsTM;

	void Start ()
	{
      
	}
	

	void Update () 
	{
		coinsTM.text = "x" + InfoScript.info.coins;
		ticketsTM.text = "x" + InfoScript.info.tickets;
	}
}
