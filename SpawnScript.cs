using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour 
{
	public GameObject TargetPrefab;
    public Texture[] randomTexture;
	
	void Start () 
	{
        randomTexture = Resources.LoadAll<Texture>("Textures");

        for (int i = 0;i < 5; i++) 
		{
            GameObject Target = Instantiate(TargetPrefab, new Vector3(i * 0.9f, 0f, 0f), Quaternion.Euler(0f, -90f, 0f)) as GameObject;
            Target.GetComponent<Renderer>().material.mainTexture = randomTexture[Random.Range(0, randomTexture.Length)];
        }

		for (int i = 0;i < 4; i++) 
		{
            GameObject Target = Instantiate(TargetPrefab, new Vector3(i * 0.9f + 0.45f, 1.5f, 0f), Quaternion.Euler(0f, -90f, 0f)) as GameObject;
            Target.GetComponent<Renderer>().material.mainTexture = randomTexture[Random.Range(0, randomTexture.Length)];
        }

		for (int i = 0;i < 3; i++) 
		{
            GameObject Target = Instantiate(TargetPrefab, new Vector3(i * 0.9f + 0.9f, 3f, 0f), Quaternion.Euler(0f, -90f, 0f)) as GameObject;
            Target.GetComponent<Renderer>().material.mainTexture = randomTexture[Random.Range(0, randomTexture.Length)];
        }

		for (int i = 0;i < 2; i++) 
		{
            GameObject Target = Instantiate(TargetPrefab, new Vector3(i * 0.9f + 1.35f, 4.5f, 0f), Quaternion.Euler(0f, -90f, 0f)) as GameObject;
            Target.GetComponent<Renderer>().material.mainTexture = randomTexture[Random.Range(0, randomTexture.Length)];
        }

		for (int i = 0;i < 1; i++) 
		{
            GameObject Target = Instantiate(TargetPrefab, new Vector3(i * 0.9f + 1.80f, 6f, 0f), Quaternion.Euler(0f, -90f, 0f)) as GameObject;
            Target.GetComponent<Renderer>().material.mainTexture = randomTexture[Random.Range(0, randomTexture.Length)];
        }

	}

	
	void Update () 
	{
		
	}
	
	
}