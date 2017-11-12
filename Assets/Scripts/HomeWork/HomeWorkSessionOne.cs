using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;


public class HomeWorkSessionOne : MonoBehaviour {


    public string text = "Hellow World";
    public bool Turn0n = true;
    public float posX = 5.0f;
    public int IntTest = 3;
    List<string> Animals = new List<string>(){"dog" , "cat"};
    Dictionary<string, string> Weapons = new Dictionary<string, string>();



    string[] Name = new string[] {"Noura", "Jesse" };



	// Use this for initialization
	void Start () {

        //Name[0] = "Noura";
        //Name[1] = "Jesse";




        //text = Test("Calling Test()");//"Updated During Start()";
        Animals.Add("fish");
        Animals.Add("mouse");

        Animals.Remove("mouse");

        Weapons.Add("Slot1", "Gun");



       
        //print("Total Names" + " " + Name.Length);
        print("Total Animals " + Animals.Count);
        print("Animal 1 " + Animals [0]);
        print("Last Animal  " + Animals[Animals.Count-1]);

        print("List To Array " + Animals.ToArray().Length);
        print("Weapon in Slot1 " + Weapons["Slot1"]);
        print("Slot 2 equipped " + Weapons.ContainsKey("Slot2"));

        // print("Secound Name " + Name[1]);



    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //My Own Method
    string Test(string Value){
        return Value+ " Updated During Test()";

        
}
    

}
