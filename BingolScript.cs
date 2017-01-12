using UnityEngine;
using System.Collections;

public class BingolScript : MonoBehaviour
{
    public Sprite pet1, pet2, pet3, pet4, pet5, pet6, pet7, pet8, pet9, pet10, pet11, pet12, pet13, pet14, pet15;
    public GameObject Body;
    public Color color;
    public Color bodyColor;

    void Start ()
    {
        color = gameObject.GetComponent<SpriteRenderer>().material.color;
        bodyColor = Body.GetComponent<SpriteRenderer>().material.color;
    }


    void Update()
    {
        color.r = 255f;
        gameObject.GetComponent<SpriteRenderer>().material.color = color;
        Body.GetComponent<SpriteRenderer>().material.color = bodyColor;


        if (InfoScript.info.pet1 == true)
        {
            bodyColor.r = 255f;
            Body.GetComponent<SpriteRenderer>().sprite = pet1;
        }

        else if (InfoScript.info.pet2 == true)
        {
            bodyColor.r = 255f;
            Body.GetComponent<SpriteRenderer>().sprite = pet2;
        }
        else if (InfoScript.info.pet3 == true)
        {
            bodyColor.r = 255f;
            Body.GetComponent<SpriteRenderer>().sprite = pet3;
        }
        else if (InfoScript.info.pet4 == true)
        {
            bodyColor.r = 255f;
            Body.GetComponent<SpriteRenderer>().sprite = pet4;
        }
        else if (InfoScript.info.pet5 == true)
        {
            bodyColor.r = 255f;
            Body.GetComponent<SpriteRenderer>().sprite = pet5;
        }
        else if (InfoScript.info.pet6 == true)
        {
            bodyColor.r = 255f;
            Body.GetComponent<SpriteRenderer>().sprite = pet6;
        }
        else if (InfoScript.info.pet7 == true)
        {
            bodyColor.r = 255f;
            Body.GetComponent<SpriteRenderer>().sprite = pet7;
        }
        else if (InfoScript.info.pet8 == true)
        {
            bodyColor.r = 255f;
            Body.GetComponent<SpriteRenderer>().sprite = pet8;
        }
        else if (InfoScript.info.pet9 == true)
        {
            bodyColor.r = 255f;
            Body.GetComponent<SpriteRenderer>().sprite = pet9;
        }
        else if (InfoScript.info.pet10 == true)
        {
            bodyColor.r = 255f;
            Body.GetComponent<SpriteRenderer>().sprite = pet10;
        }
        else if (InfoScript.info.pet11 == true)
        {
            bodyColor.r = 255f;
            Body.GetComponent<SpriteRenderer>().sprite = pet11;
        }
        else if (InfoScript.info.pet12 == true)
        {
            bodyColor.r = 255f;
            Body.GetComponent<SpriteRenderer>().sprite = pet12;
        }
        else if (InfoScript.info.pet13 == true)
        {
            bodyColor.r = 255f;
            Body.GetComponent<SpriteRenderer>().sprite = pet13;
        }
        else if (InfoScript.info.pet14 == true)
        {
            bodyColor.r = 255f;
            Body.GetComponent<SpriteRenderer>().sprite = pet14;
        }
        else if (InfoScript.info.pet15 == true)
        {
            bodyColor.r = 255f;
            Body.GetComponent<SpriteRenderer>().sprite = pet15;
        }
    }
}
