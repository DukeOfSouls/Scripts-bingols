using UnityEngine;
using System.Collections;

public class ResetScript : MonoBehaviour
{

	public void Reset ()
    {
        InfoScript.info.spawned = false;

        InfoScript.info.pet1 = false;
        InfoScript.info.pet2 = false;
        InfoScript.info.pet3 = false;
        InfoScript.info.pet4 = false;
        InfoScript.info.pet5 = false;
        InfoScript.info.pet6 = false;
        InfoScript.info.pet7 = false;
        InfoScript.info.pet8 = false;
        InfoScript.info.pet9 = false;
        InfoScript.info.pet10 = false;
        InfoScript.info.pet11 = false;
        InfoScript.info.pet12 = false;
        InfoScript.info.pet13 = false;
        InfoScript.info.pet14 = false;
        InfoScript.info.pet15 = false;

        InfoScript.info.Memory = false;
        InfoScript.info.Throw = false;
        InfoScript.info.Rps = false;

        InfoScript.info.Goggles = false;
        InfoScript.info.BlackWings = false;
        InfoScript.info.Afro = false;
        InfoScript.info.Goatee = false;
        InfoScript.info.Halo = false;
        InfoScript.info.Glasses = false;
        InfoScript.info.Hat = false;
        InfoScript.info.Necklace = false;
        InfoScript.info.Mustache = false;
        InfoScript.info.PartyGlasses = false;
        InfoScript.info.PartyHat = false;
        InfoScript.info.Pentagram = false;
        InfoScript.info.ChainNecklace = false;
        InfoScript.info.TopHat = false;
        InfoScript.info.WhiteWings = false;

        InfoScript.info.Vest = false;
        InfoScript.info.ChildDress = false;
        InfoScript.info.Gi = false;
        InfoScript.info.GirlyTop = false;
        InfoScript.info.GrungeVest = false;
        InfoScript.info.JediCoat = false;
        InfoScript.info.Dress = false;
        InfoScript.info.LeatherJacket = false;
        InfoScript.info.LongBlouse = false;
        InfoScript.info.ScifiVest = false;
        InfoScript.info.ScifiTop = false;
        InfoScript.info.Shirt = false;
        InfoScript.info.ShortBlouse = false;
        InfoScript.info.ScifiJacket = false;
        InfoScript.info.TankTop = false;
        InfoScript.info.Tuxedo = false;

        InfoScript.info.coins = 0;
        InfoScript.info.tickets = 0;
        InfoScript.info.foodCount = 0;
        InfoScript.info.drinkCount = 0;


        InfoScript.info.Save();

    }
}
