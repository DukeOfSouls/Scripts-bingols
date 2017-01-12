using UnityEngine;
using System.Collections;

public class EggScript : MonoBehaviour
{
    int activeHash = Animator.StringToHash("active");

    private int index;

    public bool spin;
    public Transform orbs;
    public Animator machine, tube, button, smoke;
    public SpriteRenderer smokeSprite;
    public GameObject egg, bingol, menu, help, clothing, accessories;


	void Start ()
    {
        spin = false;

        if (InfoScript.info.spawned == true)
        {
            egg.SetActive(false);
            bingol.SetActive(true);        
            menu.SetActive(true);
            help.SetActive(true);
            clothing.SetActive(true);
            accessories.SetActive(true);
        }

        else if (InfoScript.info.spawned == false)
        {
            egg.SetActive(true);
            bingol.SetActive(false);
            menu.SetActive(false);
            help.SetActive(false);
            clothing.SetActive(false);
            accessories.SetActive(false);
        }
        
    }
	
    public void Push ()
    {
        button.SetTrigger(activeHash);
        spin = true;
        machine.SetBool(activeHash, true);
        tube.SetBool(activeHash, true);
        Invoke("Smoke", 4f);
    }

    void Smoke ()
    {
        smokeSprite.enabled = true;
        smoke.SetBool(activeHash, true);
        Invoke("Remove", 0.5f);
    }

    void Remove ()
    {
        spin = false;
        Destroy(egg);
        Invoke("RemoveSmoke", 0.7f);
        Invoke("Birth", 0f);
    }

    void RemoveSmoke ()
    {
        smokeSprite.enabled = false;
    }

	void Update ()
    {
       
        if (spin == true) orbs.transform.Rotate(new Vector3(0f, 0f, -10f));
    }

    void Birth ()
    {
        index = Random.Range(0, 15);

         switch (index)
         {
             case 0:
                InfoScript.info.pet1 = true;
                 break;

             case 1:
                InfoScript.info.pet2 = true;
                break;

             case 2:
                InfoScript.info.pet3 = true;
                break;

             case 3:
                InfoScript.info.pet4 = true;
                break;

             case 4:
                InfoScript.info.pet5 = true;
                break;

             case 5:
                InfoScript.info.pet6 = true;
                break;

             case 6:
                InfoScript.info.pet7 = true;
                break;

             case 7:
                InfoScript.info.pet8 = true;
                break;

             case 8:
                InfoScript.info.pet9 = true;
                break;

             case 9:
                InfoScript.info.pet10 = true;
                break;

             case 10:
                InfoScript.info.pet11 = true;
                break;

             case 11:
                InfoScript.info.pet12 = true;
                break;

             case 12:
                InfoScript.info.pet13 = true;
                break;

             case 13:
                InfoScript.info.pet14 = true;
                break;

             case 14:
                InfoScript.info.pet15 = true;
                break;
         }

        InfoScript.info.spawned = true;
        StatusScript.status.energy = 2000;
        bingol.SetActive(true);
        menu.SetActive(true);
        help.SetActive(true);
        clothing.SetActive(true);
        accessories.SetActive(true);
    }
}
