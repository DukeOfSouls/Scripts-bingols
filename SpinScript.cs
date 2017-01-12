using UnityEngine;
using System.Collections;

public class SpinScript : MonoBehaviour 
{
    public GameObject backdrop;
    public GameObject loading;
    public GameObject load;

    void Start () 
	{
        InfoScript.info.Load();
        load.SetActive(false);
        backdrop.SetActive(false);
        loading.SetActive(false);
        Invoke("Begin", 2f);
	}

    void Begin ()
    {
        load.SetActive(true);
        backdrop.SetActive(true);
        loading.SetActive(true);

        AsyncOperation async = Application.LoadLevelAsync(3);
    }

	void Update () 
	{
		transform.Rotate(new Vector3(0f, 0f, -1f));
	}
}
