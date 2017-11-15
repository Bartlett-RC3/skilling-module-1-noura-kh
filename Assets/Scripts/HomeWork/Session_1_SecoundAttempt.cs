using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session_1_SecoundAttempt : MonoBehaviour {
    //Variables: 

    public int StartBalance = 100;
    float IntrestRate = 0.2f;//not public to prvent override from unity interface
   


    public string MyText = "MyCurrentBalnceIs";

    bool Pay = true;

    //Data Structuers :

    //Arrays:
    string[] MonthNmaesArray = new string[10];
    int[] MonthlyProfitArray = new int[] { 200, 250, 270 };

    //Lists:
    List<string> ExpancesList = new List<string>();
    List<int> MyNumbersList = new List<int>();

      
    



    //Functions:
    
    // Use this for initialization
    void Start() {

        //Adde/Remove Elements :

        MonthNmaesArray[0] = "May";
        MonthNmaesArray[1] = "June";
        MonthNmaesArray[2] = "July";

        MyNumbersList.Remove(7);
        MyNumbersList.Add(14);
        MyNumbersList.Add(11);
        MyNumbersList.Add(5);

        

       




        //Print to Consol:

        print("Session One Secound Attempt to Build a Solution");
        print(" John is " +" " +  StudentsAges["John"] +" " + " Years Old");

       // Debug.Log(MyText);
        Debug.Log(MyText + AddtionResult(MonthlyProfitArray[0], MonthlyProfitArray[1] , MonthlyProfitArray[2]));
        Debug.Log(" Total Items in My List Of Numbers is " + MyNumbersList.Count);


    }
        
	// Update is called once per frame
	void Update () {


		
	}

    //My Own Method :
    int AddtionResult(int VauleA, int ValueB, int ValueC)
    {
        int AddtionProcess = VauleA + ValueB + ValueC;
        return  AddtionProcess;        
    }


    

}



