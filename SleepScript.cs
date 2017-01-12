using UnityEngine;
using System.Collections;

public class SleepScript : MonoBehaviour 
{
	int pressedHash = Animator.StringToHash("pressed");
	int activeHash = Animator.StringToHash("active");

	public Animator button;
	public Animator sleepAnim;
	private bool sleep;
    public GameObject bingol;

	void Awake () 
	{
        if(InfoScript.info.sleeping == true)
        {
            sleepAnim.SetBool(activeHash, true);
            bingol.transform.position = new Vector3(-0.03f, -1.48f, 0.4f);
        }
	}
	

	void Update () 
	{
		
	}

	public void Button ()
	{
		button.SetTrigger (pressedHash);

		if(InfoScript.info.sleeping == false)
		{
			sleepAnim.SetBool (activeHash, true);
			Invoke ("Sleep", 0.1f);
		}

		if(InfoScript.info.sleeping == true)
		{
			sleepAnim.SetBool (activeHash, false);
            InfoScript.info.sleeping = false;
            Invoke("awakePos", 1f);
            

        }
	}

	void Sleep ()
	{
        InfoScript.info.sleeping = true;
        Invoke("sleepPos", 0.6f);
        
	}

    void sleepPos ()
    {
        bingol.transform.position = new Vector3(-0.03f, -1.48f, 0.4f);
    }

    void awakePos ()
    {
        bingol.transform.position = new Vector3(-0.03f, -1.84f, -0.42f);
    }
}
