using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using System.Collections.Generic;

public class BuyScript : MonoBehaviour
{
    public Dictionary<string, GameObject> objects = new Dictionary<string, GameObject>();

    public GameObject confirm;
    public TextMesh buyText;

    private string item;

    void Start()
    {
        GameObject[] blocks = GameObject.FindGameObjectsWithTag("block");

        for (int i = 0; i < blocks.Length; i++)
        {
            GameObject current = blocks[i];
            ObjectIDScript script = current.GetComponent<ObjectIDScript>();

            objects.Add(script.itemName, current);
        }

        InfoScript.info.tickets = 50;
        InfoScript.info.coins = 1000;

        //CLOTHING
        if (InfoScript.info.Vest == true)
        {
            GameObject ob;
            objects.TryGetValue("vest", out ob);
            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
        }

        if (InfoScript.info.ChildDress == true)
        {
            GameObject ob;
            objects.TryGetValue("childdress", out ob);
            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
        }

        if (InfoScript.info.Gi == true)
        {
            GameObject ob;
            objects.TryGetValue("gi", out ob);
            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
        }

        if (InfoScript.info.GirlyTop == true)
        {
            GameObject ob;
            objects.TryGetValue("girlytop", out ob);
            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
        }

        if (InfoScript.info.GrungeVest == true)
        {
            GameObject ob;
            objects.TryGetValue("grungevest", out ob);
            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
        }

        if (InfoScript.info.JediCoat == true)
        {
            GameObject ob;
            objects.TryGetValue("jedicoat", out ob);
            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
        }

        if (InfoScript.info.Dress == true)
        {
            GameObject ob;
            objects.TryGetValue("dress", out ob);
            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
        }

        if (InfoScript.info.LeatherJacket == true)
        {
            GameObject ob;
            objects.TryGetValue("leatherjacket", out ob);
            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
        }

        if (InfoScript.info.LongBlouse == true)
        {
            GameObject ob;
            objects.TryGetValue("longblouse", out ob);
            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
        }

        if (InfoScript.info.ScifiVest == true)
        {
            GameObject ob;
            objects.TryGetValue("scifivest", out ob);
            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
        }

        if (InfoScript.info.ScifiTop == true)
        {
            GameObject ob;
            objects.TryGetValue("scifitop", out ob);
            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
        }

        if (InfoScript.info.Shirt == true)
        {
            GameObject ob;
            objects.TryGetValue("shirt", out ob);
            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
        }

        if (InfoScript.info.ShortBlouse == true)
        {
            GameObject ob;
            objects.TryGetValue("shortblouse", out ob);
            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
        }

        if (InfoScript.info.ScifiJacket == true)
        {
            GameObject ob;
            objects.TryGetValue("scifijacket", out ob);
            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
        }

        if (InfoScript.info.TankTop == true)
        {
            GameObject ob;
            objects.TryGetValue("tanktop", out ob);
            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
        }

        if (InfoScript.info.Tuxedo == true)
        {
            GameObject ob;
            objects.TryGetValue("tuxedo", out ob);
            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
        }

        if (InfoScript.info.LeatherCoat == true)
        {
            GameObject ob;
            objects.TryGetValue("leathercoat", out ob);
            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
        }
    }

    void Update ()
    {

    }

    public void Yes()
    {
        if (item == "memorygame" && InfoScript.info.tickets >= 10)
        {
            GameObject ob;
            objects.TryGetValue("memorygame", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.Memory = true;
            InfoScript.info.tickets -= 10;
            InfoScript.info.Save();
        }

        else if(item == "memorygame" && InfoScript.info.tickets <= 9)
        {
            buyText.text = "You don't have\nenough tickets.";
        }

        if (item == "throwgame" && InfoScript.info.tickets >= 10) 
        {
            GameObject ob;
            objects.TryGetValue("throwgame", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.Throw = true;
            InfoScript.info.tickets -= 10;
            InfoScript.info.Save();
        }

        else if (item == "throwgame" && InfoScript.info.tickets <= 9)
        {
            buyText.text = "You don't have\nenough tickets.";
        }


        if (item == "rpsgame" && InfoScript.info.tickets >= 10)
        {
            GameObject ob;
            objects.TryGetValue("rpsgame", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.Rps = true;
            InfoScript.info.tickets -= 10;
            InfoScript.info.Save();
        }

        else if (item == "rpsgame" && InfoScript.info.tickets <= 9)
        {
            buyText.text = "You don't have\nenough tickets.";
        }

        if (item == "vest" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("vest", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.Vest = true;
            InfoScript.info.coins -= 100;
            InfoScript.info.Save();
        }

        else if (item == "vest" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "childdress" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("childdress", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.ChildDress = true;
            InfoScript.info.coins -= 100;
            InfoScript.info.Save();
        }

        else if (item == "childdress" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "gi" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("gi", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.Gi = true;
            InfoScript.info.coins -= 100;
            InfoScript.info.Save();
        }

        else if (item == "gi" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "girlytop" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("girlytop", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.GirlyTop = true;
            InfoScript.info.coins -= 100;
            InfoScript.info.Save();
        }

        else if (item == "girlytop" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "grungevest" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("grungevest", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.GrungeVest = true;
            InfoScript.info.coins -= 100;
            InfoScript.info.Save();
        }

        else if (item == "grungevest" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "jedicoat" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("jedicoat", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.JediCoat = true;
            InfoScript.info.coins -= 100;
            InfoScript.info.Save();
        }

        else if (item == "jedicoat" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "dress" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("dress", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.Dress = true;
            InfoScript.info.coins -= 100;
            InfoScript.info.Save();
        }

        else if (item == "dress" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "leatherjacket" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("leatherjacket", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.LeatherJacket = true;
            InfoScript.info.coins -= 100;
            InfoScript.info.Save();
        }

        else if (item == "leatherjacket" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "longblouse" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("longblouse", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.LongBlouse = true;
            InfoScript.info.coins -= 100;
            InfoScript.info.Save();
        }

        else if (item == "longblouse" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "scifivest" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("scifivest", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.ScifiVest = true;
            InfoScript.info.coins -= 100;
            InfoScript.info.Save();
        }

        else if (item == "scifivest" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "scifitop" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("scifitop", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.ScifiTop = true;
            InfoScript.info.coins -= 100;
            InfoScript.info.Save();
        }

        else if (item == "scifitop" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "shirt" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("shirt", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.Shirt = true;
            InfoScript.info.coins -= 100;
            InfoScript.info.Save();
        }

        else if (item == "shirt" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "shortblouse" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("shortblouse", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.ShortBlouse = true;
            InfoScript.info.coins -= 100;
            InfoScript.info.Save();
        }

        else if (item == "shortblouse" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "scifijacket" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("scifijacket", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.ScifiJacket = true;
            InfoScript.info.coins -= 100;
            InfoScript.info.Save();
        }

        else if (item == "scifijacket" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "tanktop" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("tanktop", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.TankTop = true;
            InfoScript.info.coins -= 100;
            InfoScript.info.Save();
        }

        else if (item == "tanktop" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "tuxedo" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("tuxedo", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.Tuxedo = true;
            InfoScript.info.coins -= 100;
            InfoScript.info.Save();
        }

        else if (item == "tuxedo" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "leathercoat" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("leathercoat", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.LeatherCoat = true;
            InfoScript.info.coins -= 100;
            InfoScript.info.Save();
        }

        else if (item == "leathercoat" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "goggles" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("goggles", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.Goggles = true;
            InfoScript.info.tickets -= 5;
            InfoScript.info.Save();
        }

        else if (item == "goggles" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "blackwings" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("blackwings", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.BlackWings = true;
            InfoScript.info.tickets -= 5;
            InfoScript.info.Save();
        }

        else if (item == "blackwings" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "afro" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("afro", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.Afro = true;
            InfoScript.info.tickets -= 5;
            InfoScript.info.Save();
        }

        else if (item == "afro" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "goatee" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("goatee", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.Goatee = true;
            InfoScript.info.tickets -= 5;
            InfoScript.info.Save();
        }

        else if (item == "goatee" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "halo" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("halo", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.Halo = true;
            InfoScript.info.tickets -= 5;
            InfoScript.info.Save();
        }

        else if (item == "halo" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "glasses" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("glasses", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.Glasses = true;
            InfoScript.info.tickets -= 5;
            InfoScript.info.Save();
        }

        else if (item == "glasses" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "hat" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("hat", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.Hat = true;
            InfoScript.info.tickets -= 5;
            InfoScript.info.Save();
        }

        else if (item == "hat" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "necklace" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("necklace", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.Necklace = true;
            InfoScript.info.tickets -= 5;
            InfoScript.info.Save();
        }

        else if (item == "necklace" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "mustache" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("mustache", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.Mustache = true;
            InfoScript.info.tickets -= 5;
            InfoScript.info.Save();
        }

        else if (item == "mustache" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "partyglasses" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("partyglasses", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.PartyGlasses = true;
            InfoScript.info.tickets -= 5;
            InfoScript.info.Save();
        }

        else if (item == "partyglasses" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "partyhat" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("partyhat", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.PartyHat = true;
            InfoScript.info.tickets -= 5;
            InfoScript.info.Save();
        }

        else if (item == "partyhat" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "pentagram" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("pentagram", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.Pentagram = true;
            InfoScript.info.tickets -= 5;
            InfoScript.info.Save();
        }

        else if (item == "pentagram" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "chainnecklace" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("chainnecklace", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.ChainNecklace = true;
            InfoScript.info.tickets -= 5;
            InfoScript.info.Save();
        }

        else if (item == "chainnecklace" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "tophat" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("tophat", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.TopHat = true;
            InfoScript.info.tickets -= 5;
            InfoScript.info.Save();
        }

        else if (item == "tophat" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }

        if (item == "whitewings" && InfoScript.info.coins >= 100)
        {
            GameObject ob;
            objects.TryGetValue("whitewings", out ob);

            SpriteRenderer SR = ob.transform.Find("Blocked").gameObject.GetComponent<SpriteRenderer>();
            SR.enabled = true;
            confirm.SetActive(false);
            InfoScript.info.WhiteWings = true;
            InfoScript.info.tickets -= 5;
            InfoScript.info.Save();
        }

        else if (item == "whitewings" && InfoScript.info.coins <= 99)
        {
            buyText.text = "You don't have\nenough coins.";
        }
    }

    public void No()
    {
        confirm.SetActive(false);
        item = null;
    }

    // ALL MINIGAMES
    public void MemoryGame()
    {
        if (InfoScript.info.Memory == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "memorygame";
        }
    }

    public void ThrowGame()
    {
        if (InfoScript.info.Throw == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "throwgame";
        }
    }

    public void RPSgame()
    {
        if (InfoScript.info.Rps == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "rpsgame";
        }
    }

    //ALL CLOTHING
    public void Vest ()
    {
        if (InfoScript.info.Vest == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "vest";
        }
    }

    public void ChildDress ()
    {
        if (InfoScript.info.ChildDress == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "childdress";
        }
    }

    public void Gi ()
    {
        if (InfoScript.info.Gi == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "gi";
        }
    }

    public void GirlyTop ()
    {
        if (InfoScript.info.GirlyTop == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "girlytop";
        }
    }

    public void GrungeVest ()
    {
        if (InfoScript.info.GrungeVest == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "grungevest";
        }
    }

    public void JediCoat ()
    {
        if (InfoScript.info.JediCoat == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "jedicoat";
        }
    }

    public void Dress ()
    {
        if (InfoScript.info.Dress == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "dress";
        }
    }

    public void LeatherJacket ()
    {
        if (InfoScript.info.LeatherJacket == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "leatherjacket";
        }
    }

    public void LongBlouse ()
    {
        if (InfoScript.info.LongBlouse == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "longblouse";
        }
    }
    
    public void ScifiVest ()
    {
        if (InfoScript.info.ScifiVest == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "scifivest";
        }
    }
    
    public void ScifiTop ()
    {
        if (InfoScript.info.ScifiTop == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "scifitop";
        }
    }

    public void Shirt ()
    {
        if (InfoScript.info.Shirt == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "shirt";
        }
    }

    public void ShortBlouse ()
    {
        if (InfoScript.info.ShortBlouse == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "shortblouse";
        }
    }

    public void ScifiJacket ()
    {
        if (InfoScript.info.ScifiJacket == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "scifijacket";
        }

    }

    public void TankTop ()
    {
        if (InfoScript.info.TankTop == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "tanktop";
        }
    }

    public void Tuxedo ()
    {
        if (InfoScript.info.Tuxedo == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "tuxedo";
        }
    }

    public void LeatherCoat ()
    {
        if (InfoScript.info.LeatherCoat == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "leathercoat";
        }
    }


    //ALL ACCESSORIES

    public void Goggles ()
    {
       if(InfoScript.info.Goggles == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "goggles";
        }
    }

    public void BlackWings()
    {
        if (InfoScript.info.BlackWings == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "blackwings";
        }
    }

    public void Afro()
    {
        if (InfoScript.info.Afro == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "afro";
        }
    }

    public void Goatee ()
    {
        if (InfoScript.info.Goatee == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "goatee";
        }
    }

    public void Halo ()
    {
        if (InfoScript.info.Halo == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "halo";
        }
    }

    public void Glasses ()
    {
        if (InfoScript.info.Glasses == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "glasses";
        }
    }

    public void Hat ()
    {
        if (InfoScript.info.Hat == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "hat";
        }
    }

    public void Necklace ()
    {
        if (InfoScript.info.Necklace == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "necklace";
        }
    }

    public void Mustache ()
    {
        if (InfoScript.info.Mustache == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "mustache";
        }
    }

    public void PartyGlasses ()
    {
        if (InfoScript.info.PartyGlasses == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "partyglasses";
        }
    }

    public void PartyHat ()
    {
        if (InfoScript.info.PartyHat == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "partyhat";
        }
    }

    public void Pentagram ()
    {
        if (InfoScript.info.Pentagram == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "pentagram";
        }
    }

    public void ChainNeclace ()
    {
        if (InfoScript.info.ChainNecklace== false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "chainnecklace";
        }
    }

    public void TopHat()
    {
        if (InfoScript.info.TopHat == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "tophat";
        }
    }

    public void WhiteWhings()
    {
        if (InfoScript.info.WhiteWings == false)
        {
            buyText.text = "Do you want to\nbuy this item?";
            confirm.SetActive(true);
            item = "whitewings";
        }
    }


}