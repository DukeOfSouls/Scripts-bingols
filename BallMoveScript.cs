using UnityEngine;
using System.Collections;

public class BallMoveScript : MonoBehaviour 
{
	public float speed;

	void Start ()
	{
		speed = Random.Range (2f, 10f);
	}

	void Update ()
	{
		transform.position += Vector3.up * Time.deltaTime * speed;
	}

	void OnTriggerEnter (Collider col)
	{
		if(col.tag == "wall")
		{
			Destroy (gameObject);
		}
	}
	
}