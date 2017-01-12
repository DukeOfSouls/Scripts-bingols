using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LookScript : MonoBehaviour 
{
	int pressedHash = Animator.StringToHash("pressed");

    public MeshRenderer loseText, winText;
	public MeshRenderer mist;
    public GameObject RetryMenu;
	public Transform bingocard2, target, target2;
	public bool eye;
	public BingoScript BS;
	public DetectScript DS;
	public DetectScript2 DS2;
	public WinScript WS;
	public GameObject[] BUTTS;
	public float speed;
	public Animator greenButton;

	void Start ()
	{
		BUTTS = GameObject.FindGameObjectsWithTag("button");
		eye = false;
	}

	public void Eye ()
	{
		 eye = !eye;
	}

	public void BINGO ()
	{
		greenButton.SetTrigger (pressedHash);

		Invoke ("Bingo", 0.5f);

	}

	void Bingo ()
	{
		if(BS.bingoCounter == 24)
		{
			Debug.Log ("YOU WIN");
			BS.smokeSprite.enabled = false;
			BS.enabled = false;
			DS.enabled = false;
			DS2.enabled = false;
			foreach(GameObject image in BUTTS)
			{
				image.GetComponent<Image>().enabled = false;
			}
			WS.enabled = true;
		}
		
		else
			
		{
			Debug.Log ("YOU LOSE");
			BS.smokeSprite.enabled = false;
			BS.enabled = false;
			DS.enabled = false;
			DS2.enabled = false;
			foreach(GameObject image in BUTTS)
			{
				image.GetComponent<Image>().enabled = false;
			}

			mist.enabled = true;
			loseText.enabled = true;

			Invoke ("Retry", 1.5f);


		}
	}

	void Retry ()
	{
        loseText.enabled = false;
        RetryMenu.SetActive(true);
	}

	void FixedUpdate ()
	{
		if(eye == true)
		{
			bingocard2.transform.position = Vector3.MoveTowards(bingocard2.transform.position, target2.position, speed * Time.deltaTime);
		}

		if(eye == false)
		{
			bingocard2.transform.position = Vector3.MoveTowards(bingocard2.transform.position, target.position, speed * Time.deltaTime);
		}
	}
}
