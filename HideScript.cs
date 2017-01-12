using UnityEngine;
using System.Collections;

public class HideScript : MonoBehaviour
{
    public GameObject bingol;


	void Start ()
    {
	    if(InfoScript.info.sleeping == true && InfoScript.info.spawned == true)
        {
            bingol.SetActive(false);
        }

        else if(InfoScript.info.sleeping == false && InfoScript.info.spawned == true)
        {
            bingol.SetActive(true);
        }

	}
	

	void Update ()
    {
	    
	}
}
