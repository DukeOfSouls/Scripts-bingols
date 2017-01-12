using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class ButtonScript : MonoBehaviour 
{
	public DetectScript DS;
	public Component[] sprite;
	public Component[] hitbox;


	public void Button ()
	{
		Debug.Log ("banaan");
		sprite = GetComponentsInChildren<SpriteRenderer>();
		foreach(SpriteRenderer renderer in sprite)
		{
			renderer.enabled = !renderer.enabled;
		}

		hitbox = GetComponentsInChildren<BoxCollider>();
		foreach(BoxCollider collider in hitbox)
		{
			collider.enabled = !collider.enabled;
		}
	}


}
