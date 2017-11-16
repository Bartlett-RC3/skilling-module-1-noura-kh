using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class HomeWork_Session2 : MonoBehaviour
{

    public int MyNumber = 2;
    public bool Power = true;
    int Sate0fNetwork; 

    string[] ColorsArray = {"Red","Gree","Blue"};
    List<int> OddNumbersList = new List<int>();
    int[] OddNumbersSmart = new int[10];
    


    // Use this for initialization
    void Start()
    {
        //Test for Condtional Statements:
        if ( MyNumber == 2)
        {
            Debug.Log("My Number is 2");
        }
        else
        {
            Debug.Log("My Number is not 2");
        }

        //Short If statement:

        if (Power)
        {
            Debug.Log(" POwer is on");
        }
        else
        {
            Debug.Log("POwer is Off");
        }

        //Condtional Boolean:

        Sate0fNetwork = (Power == true) ? 1 : 0;
        Debug.Log(" State 0f The Power Network " + Sate0fNetwork);

        //Question Concantenation:

        if ( MyNumber ==2 && Power == true)
        {
            Debug.Log(" My Number is 2 and The Power is on");
        }

        //Question or Statement :

        if( MyNumber ==2 || Power == true)
        {
            Debug.Log(" Either Your Number is 2 OR Your Network Power is on");

        }

        //Loops:

        for (int i = 0; i < ColorsArray.Length; i = i + 1) {
            Debug.Log("Color Number " + i + " is " + ColorsArray[i]);

        }

        //Add 1o Odd Numbers to the list and to the array :
        for ( int i=1; i<10; i= i +2) 
        {
            OddNumbersList.Add(i);
            ///OddNumbersSmart[i] = i;
        }

        // Print the list: 
        for (int i = 0; i < OddNumbersList.Count; i = i + 1)
        {
            Debug.Log(" The Odd Number is " + OddNumbersList[i]);
        }
        // Add 25 Numbers to the list and print numbers divised by 3 :
        /*List<int> My12NumberList = new List<int>();
        //First Adding the numbers :
        for (int i = 0; i < 12; i = i++)
        {
            My12NumberList.Add(i);
        }
        //Now to choose the devisable numbers at 3:


        for (int i = 0; i < My12NumberList.Count; i = i + 3)
        {
            Debug.Log("Numbers divided by 3 " + My12NumberList[i]);
        }*/ // Commented out because system was out of memory 


        BiologicalAttributes CreatureNumber0ne = new BiologicalAttributes("Human", false, 5.2f, 60);
        BiologicalAttributes CreatureNumberTow = new BiologicalAttributes("Tiger", false, 8.4f, 34);
        BiologicalAttributes CreatureNumberThree = new BiologicalAttributes("Eagel", true, 9.0f, 10);




    }

    // Update is called once per frame
    void Update()
    {



    }

    public void  HumanAverageSpeed()
    {
        BiologicalAttributes CreatureNumber0ne = new BiologicalAttributes("Human", false, 5.2f, 60);

        /////QUESTION : how can I assign the speed value here in the scirpt outside the class?
        // CreatureNumber0ne .SetSpeed     ? 
        /////QUESTION : how can I extract the speed assigned from the declared field up ?



    }










}    
    
       

