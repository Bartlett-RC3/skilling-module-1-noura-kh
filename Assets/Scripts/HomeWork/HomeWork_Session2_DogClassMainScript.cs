using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyDogs;

public class HomeWork_Session2_DogClassMainScript : MonoBehaviour {


    





    // Use this for initialization
    void Start () {

        IDogClass MynewDog = new LabradorRetriever();
         print(" My Dog Color is " + MynewDog.Color);
         print( "My Dogs Aging rate is " + MynewDog.CurrentAging() + "%");


        DogClass BullDog = new DogClass(3, 10, "BullDog", "White", 15);
        IDogClass JohnNewDog = new DogClass(5, 10, "Lab", "Brown", 11);



    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
