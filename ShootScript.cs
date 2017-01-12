using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShootScript : MonoBehaviour 
{
    public WinScript2 WS2;
    public SpriteRenderer coin;
    public PathScript PS;
	public Rigidbody stone;
	public Transform origine;
	public float Force;
    public TextMesh Text, coinCount;
	private int ballCount = 3;
	public Transform background;
    public GameObject RetryMenu;

    public int count;
	
	void Update () 
	{
		Text.text = "" + ballCount;

		if(ballCount == 0)
		{
			Invoke ("Gameover", 2.5f);
			this.enabled = false;
			PS.enabled = false;
		}

		if(Input.GetMouseButtonDown(0))
		{
			Rigidbody instance;
			instance = Instantiate(stone, origine.position + origine.transform.forward * 1.5f, origine.rotation) as Rigidbody;
			instance.AddForce(origine.transform.forward * Force);
			ballCount--;
		}
	}

	void Gameover ()
	{
        Debug.Log(count);
		background.transform.position = new Vector3 (1.827f, 2.46f, -10f);
        RetryMenu.SetActive(true);
        coin.enabled = true;

        if(count == 15)
        {
            InfoScript.info.coins += 5;
            coinCount.text = "+5";
            WS2.enabled = true;
        }

        else
        {
            InfoScript.info.coins += 1;
            coinCount.text = "+1";
        }
    }
}

