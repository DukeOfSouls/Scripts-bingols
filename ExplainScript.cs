using UnityEngine;
using System.Collections;

public class ExplainScript : MonoBehaviour {

    Vector3 pos = new Vector3(0f, 0f, 0f);
    public GameObject InfoScreen;

	void Start ()
    {
        pos = gameObject.transform.position;
        InfoScreen.SetActive(false);
	}
	

	void Update ()
    {

	}

    public void Open ()
    {
        InfoScreen.SetActive(true);
        gameObject.transform.position = new Vector3(10f, 10f, 10f);
    }

    public void Close ()
    {
        InfoScreen.SetActive(false);
        gameObject.transform.position = pos;
    }
}
