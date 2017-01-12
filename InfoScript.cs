using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class InfoScript : MonoBehaviour 
{
	public static InfoScript info;
	


	public int coins, tickets, foodCount, drinkCount;
    public bool Memory = false, Rps = false, Throw = false;
    public bool Vest, ChildDress, Gi, GirlyTop, GrungeVest, JediCoat, Dress, LeatherJacket, LongBlouse, ScifiVest, ScifiTop, Shirt, ShortBlouse, ScifiJacket, TankTop, Tuxedo, LeatherCoat;
    public bool Goggles, BlackWings, Afro, Goatee, Halo, Glasses, Hat, Necklace, Mustache, PartyGlasses, PartyHat, Pentagram, ChainNecklace, TopHat, WhiteWings;
    public bool pet1, pet2, pet3, pet4, pet5, pet6, pet7, pet8, pet9, pet10, pet11, pet12, pet13, pet14, pet15;
    public bool spawned, sleeping;

	void Awake()
    { 
		if(info == null)
		{
			DontDestroyOnLoad(gameObject);
			info = this;
		}
		
		else if(info != this)
		{
			Destroy(gameObject);
		}
	}
	
	public void Save()
	{
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/info.dat");
		
		GameData data = new GameData();

        data.spawned = spawned;
        data.sleeping = sleeping;

        data.pet1 = pet1;
        data.pet2 = pet2;
        data.pet3 = pet3;
        data.pet4 = pet4;
        data.pet5 = pet5;
        data.pet6 = pet6;
        data.pet7 = pet7;
        data.pet8 = pet8;
        data.pet9 = pet9;
        data.pet10 = pet10;
        data.pet11 = pet11;
        data.pet12 = pet12;
        data.pet13 = pet13;
        data.pet14 = pet14;
        data.pet15 = pet15;

        data.Vest = Vest;
        data.ChildDress = ChildDress;
        data.Gi = Gi;
        data.GirlyTop = GirlyTop;
        data.GrungeVest = GrungeVest;
        data.JediCoat = JediCoat;
        data.Dress = Dress;
        data.LeatherJacket = LeatherJacket;
        data.LongBlouse = LongBlouse;
        data.ScifiVest = ScifiVest;
        data.ScifiTop = ScifiTop;
        data.Shirt = Shirt;
        data.ShortBlouse = ShortBlouse;
        data.ScifiJacket = ScifiJacket;
        data.TankTop = TankTop;
        data.Tuxedo = Tuxedo;
        data.LeatherCoat = LeatherCoat;

        data.Goggles = Goggles;
        data.BlackWings = BlackWings;
        data.Afro = Afro;
        data.Goatee = Goatee;
        data.Halo = Halo;
        data.Glasses = Glasses;
        data.Hat = Hat;
        data.Necklace = Necklace;
        data.Mustache = Mustache;
        data.PartyGlasses = PartyGlasses;
        data.PartyHat = PartyHat;
        data.Pentagram = Pentagram;
        data.ChainNecklace = ChainNecklace;
        data.TopHat = TopHat;
        data.WhiteWings = WhiteWings;

		data.coins = coins;
		data.tickets = tickets;
		data.foodCount = foodCount;
		data.drinkCount = drinkCount;
        data.Memory = Memory;
        data.Throw = Throw;
        data.Rps = Rps;

		bf.Serialize(file, data);
		file.Close();
	}
	
	
	public void Load()
	{
		if(File.Exists(Application.persistentDataPath + "/info.dat"));
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/info.dat", FileMode.Open);
			GameData data = (GameData)bf.Deserialize(file);
			file.Close();

            spawned = data.spawned;
            sleeping = data.sleeping;

            pet1 = data.pet1;
            pet2 = data.pet2;
            pet3 = data.pet3;
            pet4 = data.pet4;
            pet5 = data.pet5;
            pet6 = data.pet6;
            pet7 = data.pet7;
            pet8 = data.pet8;
            pet9 = data.pet9;
            pet10 = data.pet10;
            pet11 = data.pet11;
            pet12 = data.pet12;
            pet13 = data.pet13;
            pet14 = data.pet14;
            pet15 = data.pet15;

            Vest = data.Vest;
            ChildDress = data.ChildDress;
            Gi = data.Gi;
            GirlyTop = data.GirlyTop;
            GrungeVest = data.GrungeVest;
            JediCoat = data.JediCoat;
            Dress = data.Dress;
            LeatherJacket = data.LeatherJacket;
            LongBlouse = data.LongBlouse;
            ScifiVest = data.ScifiVest;
            ScifiTop = data.ScifiTop;
            Shirt = data.Shirt;
            ShortBlouse = data.ShortBlouse;
            ScifiJacket = data.ScifiJacket;
            TankTop = data.TankTop;
            Tuxedo = data.Tuxedo;
            LeatherCoat = data.LeatherCoat;

            Goggles = data.Goggles;
            BlackWings = data.BlackWings;
            Afro = data.Afro;
            Goatee = data.Goatee;
            Halo = data.Halo;
            Glasses = data.Glasses;
            Hat = data.Hat;
            Necklace = data.Necklace;
            Mustache = data.Mustache;
            PartyGlasses = data.PartyGlasses;
            PartyHat = data.PartyHat;
            Pentagram = data.Pentagram;
            ChainNecklace = data.ChainNecklace;
            TopHat = data.TopHat;
            WhiteWings = data.WhiteWings;

            coins = data.coins;
			tickets = data.tickets;
			foodCount = data.foodCount;
			drinkCount = data.drinkCount;
            Memory = data.Memory;
            Throw = data.Throw;
            Rps = data.Rps;
		}
	}


    void OnApplicationQuit()
    {
        InfoScript.info.Save();
    }
}

[Serializable]
class GameData
{
	public int coins, tickets, foodCount, drinkCount;
    public bool Memory, Rps, Throw;
    public bool Vest, ChildDress, Gi, GirlyTop, GrungeVest, JediCoat, Dress, LeatherJacket, LongBlouse, ScifiVest, ScifiTop, Shirt, ShortBlouse, ScifiJacket, TankTop, Tuxedo;
    public bool Goggles, BlackWings, Afro, Goatee, Halo, Glasses, Hat, Necklace, Mustache, PartyGlasses, PartyHat, Pentagram, ChainNecklace, TopHat, WhiteWings, LeatherCoat;
    public bool pet1, pet2, pet3, pet4, pet5, pet6, pet7, pet8, pet9, pet10, pet11, pet12, pet13, pet14, pet15;
    public bool spawned, sleeping;
}