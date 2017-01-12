using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class EquipScript : MonoBehaviour
{

    public GameObject[] temp_clothing;
    public Dictionary<string, GameObject> clothing = new Dictionary<string, GameObject>();
    public SelectScript selectScript;

    void Start()
    {

        temp_clothing = GameObject.FindGameObjectsWithTag("cloth");
        foreach (GameObject ob in temp_clothing)
        {
            clothing.Add(ob.name, ob);
            ob.SetActive(false);
        }

    }

    void Unequip ()
    {
        foreach (GameObject ob in clothing.Values)
        {
            ob.SetActive(false);
        }
    }

    public void Equip()
    {
        if (InfoScript.info.Vest == true && selectScript.selected1 == 0)
        {
            Unequip();
            clothing[selectScript.clothes[0].name].SetActive(true);     
        }

        if (InfoScript.info.ChildDress == true && selectScript.selected1 == 1)
        {
            Unequip();
            clothing[selectScript.clothes[1].name].SetActive(true);
        }

        if (InfoScript.info.Gi == true && selectScript.selected1 == 2)
        {
            Unequip();
            clothing[selectScript.clothes[2].name].SetActive(true);
        }

        if (InfoScript.info.GirlyTop == true && selectScript.selected1 == 3)
        {
            Unequip();
            clothing[selectScript.clothes[3].name].SetActive(true);
        }

        if (InfoScript.info.GrungeVest == true && selectScript.selected1 == 4)
        {
            Unequip();
            clothing[selectScript.clothes[4].name].SetActive(true);
        }

        if (InfoScript.info.JediCoat == true && selectScript.selected1 == 5)
        {
            Unequip();
            clothing[selectScript.clothes[5].name].SetActive(true);
        }

        if (InfoScript.info.Dress == true && selectScript.selected1 == 6)
        {
            Unequip();
            clothing[selectScript.clothes[6].name].SetActive(true);
        }

        if (InfoScript.info.LeatherJacket == true && selectScript.selected1 == 7)
        {
            Unequip();
            clothing[selectScript.clothes[7].name].SetActive(true);
        }

        if (InfoScript.info.LongBlouse == true && selectScript.selected1 == 8)
        {
            Unequip();
            clothing[selectScript.clothes[8].name].SetActive(true);
        }

        if (InfoScript.info.ScifiVest == true && selectScript.selected1 == 9)
        {
            Unequip();
            clothing[selectScript.clothes[9].name].SetActive(true);
        }

        if (InfoScript.info.ScifiTop == true && selectScript.selected1 == 10)
        {
            Unequip();
            clothing[selectScript.clothes[10].name].SetActive(true);
        }

        if (InfoScript.info.Shirt == true && selectScript.selected1 == 11)
        {
            Unequip();
            clothing[selectScript.clothes[11].name].SetActive(true);
        }

        if (InfoScript.info.ShortBlouse == true && selectScript.selected1 == 12)
        {
            Unequip();
            clothing[selectScript.clothes[12].name].SetActive(true);
        }

        if (InfoScript.info.ScifiJacket == true && selectScript.selected1 == 13)
        {
            Unequip();
            clothing[selectScript.clothes[13].name].SetActive(true);
        }

        if (InfoScript.info.TankTop == true && selectScript.selected1 == 14)
        {
            Unequip();
            clothing[selectScript.clothes[14].name].SetActive(true);
        }

        if (InfoScript.info.Tuxedo == true && selectScript.selected1 == 15)
        {
            Unequip();
            clothing[selectScript.clothes[15].name].SetActive(true);
        }

        if (InfoScript.info.LeatherCoat == true && selectScript.selected1 == 16)
        {
            Unequip();
            clothing[selectScript.clothes[16].name].SetActive(true);
        }



    }
}
