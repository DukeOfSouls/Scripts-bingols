using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SelectScript : MonoBehaviour
{
    public SpriteRenderer[] clothes;
    public SpriteRenderer[] Accessories;

    public GameObject clothing, accessories, locked;
    public int selected1, selected2;
    private Vector3 StartScale1, StartScale2;
    private bool scaling1, scaling2;

    void Start()
    {
        /*scaling1 = false;
        scaling2 = false;
        StartScale1 = clothing.transform.localScale;
        StartScale2 = accessories.transform.localScale;

        clothing.transform.localScale = new Vector3(0.042f, 0.034f, 0.03f);
        accessories.transform.localScale = new Vector3(0.042f, 0.034f, 0.03f);*/

        selected1 = 0;
        selected2 = 0;

        clothes = Resources.LoadAll<SpriteRenderer>("Clothes");
        Accessories = Resources.LoadAll<SpriteRenderer>("Accessories");
    }

    void Update()
    {
        /*if (clothing.GetComponent<Image>().sprite == locked.GetComponent<SpriteRenderer>().sprite)
        {
            clothing.transform.localScale = new Vector3(0.042f, 0.034f, 0.03f);
        }

        else
        {
            if (scaling1 == true)
            {
                clothing.transform.localScale = StartScale1;
            }

        }

        if(accessories.GetComponent<Image>().sprite == locked.GetComponent<SpriteRenderer>().sprite)
        {
            accessories.transform.localScale = new Vector3(0.042f, 0.034f, 0.03f);
        }

        else
        {
            if (scaling2 == true)
            {
                accessories.transform.localScale = StartScale2;
            }
        }*/
    }

    public void UpClothing ()
    {
        //if (scaling1 == false) scaling1 = true;

        if (selected1 == 16)
        {
            selected1 = 0;

            if (InfoScript.info.Vest == false)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }
            
            else if (InfoScript.info.Vest == true && selected1 == 0)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }
        }

        else
        {
            selected1++;

            if (InfoScript.info.ChildDress == false && selected1 == 1)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.ChildDress == true && selected1 == 1)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.Gi == false && selected1 == 2)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Gi == true && selected1 == 2)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.GirlyTop == false && selected1 == 3)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.GirlyTop == true && selected1 == 3)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.GrungeVest == false && selected1 == 4)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.GrungeVest == true && selected1 == 4)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.JediCoat == false && selected1 == 5)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.JediCoat == true && selected1 == 5)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.Dress == false && selected1 == 6)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Dress == true && selected1 == 6)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.LeatherJacket == false && selected1 == 7)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.LeatherJacket == true && selected1 == 7)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.LongBlouse == false && selected1 == 8)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.LongBlouse == true && selected1 == 8)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.ScifiVest == false && selected1 == 9)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.ScifiVest == true && selected1 == 9)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.ScifiTop == false && selected1 == 10)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.ScifiTop == true && selected1 == 10)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.Shirt == false && selected1 == 11)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Shirt == true && selected1 == 11)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.ShortBlouse == false && selected1 == 12)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.ShortBlouse == true && selected1 == 12)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.ScifiJacket == false && selected1 == 13)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.ScifiJacket == true && selected1 == 13)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.TankTop == false && selected1 == 14)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.TankTop == true && selected1 == 14)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.Tuxedo == false && selected1 == 15)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Tuxedo == true && selected1 == 15)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.LeatherCoat == false && selected1 == 16)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.LeatherCoat == true && selected1 == 16)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }
        }
    }

    public void DownClothing ()
    {
       // if (scaling1 == false) scaling1 = true;

        if (selected1 == 0)
        {
            selected1 = 16;

            if (InfoScript.info.LeatherCoat == false)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.LeatherCoat == true && selected1 == 16)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }
        }

        else
        {
            selected1--;

            if (InfoScript.info.Vest == false)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Vest == true && selected1 == 0)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.ChildDress == false && selected1 == 1)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.ChildDress == true && selected1 == 1)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.Gi == false && selected1 == 2)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Gi == true && selected1 == 2)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.GirlyTop == false && selected1 == 3)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.GirlyTop == true && selected1 == 3)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.GrungeVest == false && selected1 == 4)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.GrungeVest == true && selected1 == 4)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.JediCoat == false && selected1 == 5)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.JediCoat == true && selected1 == 5)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.Dress == false && selected1 == 6)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Dress == true && selected1 == 6)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.LeatherJacket == false && selected1 == 7)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.LeatherJacket == true && selected1 == 7)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.LongBlouse == false && selected1 == 8)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.LongBlouse == true && selected1 == 8)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.ScifiVest == false && selected1 == 9)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.ScifiVest == true && selected1 == 9)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.ScifiTop == false && selected1 == 10)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.ScifiTop == true && selected1 == 10)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.Shirt == false && selected1 == 11)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Shirt == true && selected1 == 11)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.ShortBlouse == false && selected1 == 12)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.ShortBlouse == true && selected1 == 12)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.ScifiJacket == false && selected1 == 13)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.ScifiJacket == true && selected1 == 13)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.TankTop == false && selected1 == 14)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.TankTop == true && selected1 == 14)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }

            if (InfoScript.info.Tuxedo == false && selected1 == 15)
            {
                clothing.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Tuxedo == true && selected1 == 15)
            {
                clothing.GetComponent<Image>().sprite = clothes[selected1].sprite;
            }
        }
    }

    public void UpAccessories ()
    {
       // if (scaling2 == false) scaling2 = true;

        if (selected2 == 14)
        {
            selected2 = 0;

            if (InfoScript.info.Goggles == false)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Goggles == true && selected2 == 0)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }
        }

        else
        {
            selected2++;

            if (InfoScript.info.BlackWings == false && selected2 == 1)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.BlackWings == true && selected2 == 1)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.Afro == false && selected2 == 2)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Afro == true && selected2 == 2)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.Goatee == false && selected2 == 3)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Goatee == true && selected2 == 3)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.Halo == false && selected2 == 4)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Halo == true && selected2 == 4)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.Glasses == false && selected2 == 5)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Glasses == true && selected2 == 5)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.Hat == false && selected2 == 6)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Hat == true && selected2 == 6)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.Necklace == false && selected2 == 7)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Necklace == true && selected2 == 7)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.Mustache == false && selected2 == 8)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Mustache == true && selected2 == 8)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.PartyGlasses == false && selected2 == 9)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.PartyGlasses == true && selected2 == 9)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.PartyHat == false && selected2 == 10)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.PartyHat == true && selected2 == 10)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.Pentagram == false && selected2 == 11)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Pentagram == true && selected2 == 11)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.ChainNecklace == false && selected2 == 12)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.ChainNecklace == true && selected2 == 12)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.TopHat == false && selected2 == 13)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.TopHat == true && selected2 == 13)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.WhiteWings == false && selected2 == 14)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.WhiteWings == true && selected2 == 14)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

        }
    }

    public void DownAccessories ()
    {
       // if (scaling2 == false) scaling2 = true;

        if (selected2 == 0)
        {
            selected2 = 14;

            if (InfoScript.info.WhiteWings == false)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.WhiteWings == true && selected2 == 14)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }
        }

        else
        {
            selected2--;

            if (InfoScript.info.Goggles == false && selected2 == 0)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Goggles == true && selected2 == 0)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.BlackWings == false && selected2 == 1)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.BlackWings == true && selected2 == 1)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.Afro == false && selected2 == 2)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Afro == true && selected2 == 2)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.Goatee == false && selected2 == 3)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Goatee == true && selected2 == 3)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.Halo == false && selected2 == 4)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Halo == true && selected2 == 4)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.Glasses == false && selected2 == 5)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Glasses == true && selected2 == 5)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.Hat == false && selected2 == 6)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Hat == true && selected2 == 6)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.Necklace == false && selected2 == 7)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Necklace == true && selected2 == 7)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.Mustache == false && selected2 == 8)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Mustache == true && selected2 == 8)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.PartyGlasses == false && selected2 == 9)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.PartyGlasses == true && selected2 == 9)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.PartyHat == false && selected2 == 10)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.PartyHat == true && selected2 == 10)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.Pentagram == false && selected2 == 11)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.Pentagram == true && selected2 == 11)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.ChainNecklace == false && selected2 == 12)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.ChainNecklace == true && selected2 == 12)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

            if (InfoScript.info.TopHat == false && selected2 == 13)
            {
                accessories.GetComponent<Image>().sprite = locked.GetComponent<SpriteRenderer>().sprite;
            }

            else if (InfoScript.info.TopHat == true && selected2 == 13)
            {
                accessories.GetComponent<Image>().sprite = Accessories[selected2].sprite;
            }

        }
    }
}
