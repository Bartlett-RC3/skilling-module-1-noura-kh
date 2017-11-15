//Session2: Conditionals , Loops and Classes
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolSession2 : MonoBehaviour {
    //Vraiables:

    public int myNumber = 2;
    public bool questionTime = false;
    public int myVariableQuestionTime;
    public string[] fruits = { "bannana", "apple", "mango", "orange" };
    public List<int> evenNumbers = new List<int>();
    public int[] evenNumbersSmart = new int[10];
	// Use this for initialization
	void Start () {
        myVariableQuestionTime = (questionTime) ? 1 : 0;
        Debug.Log("The Value Of myVariableQuestionTime is " + myVariableQuestionTime);




    }
	


	// Update is called once per frame
	void Update () {
        /*
        if (myNumber == 2)
        {
            Debug.Log("Your Number is equal to 2.");


        }
        else
        {
            Debug.Log("Your Number is not  equal to 2.");
        }
        */

        if (questionTime == false)
        {
            Debug.Log("Question Time is true");

        }else
        {
            Debug.Log("Question Time is false");
        }

        //
        if (myNumber == 2 && questionTime == false) ;
        {
            Debug.Log("Your Number is 2 and QT is False");

        }

        //
        if (myNumber == 2 ||questionTime == false) ;
        {
            Debug.Log("it may be that your number is 2 or it may be that QT is false");

        }
        //

        //for Looop statment (start value ,how this ends , incremntaion )
        for (int i = 0; i < fruits.Length; i = i + 1)

        {
            Debug.Log( "Fruit at position " +i +"is" + fruits[1]);

        }

        ///
        for (int i=0; i<20; i=1+2)
        {
            evenNumbers.Add(i);
            evenNumbersSmart[1 / 2] = i;
        }
        for (int i = 0; 1 < evenNumbers.Count; i++)
        {
            Debug.Log("My Even Number is " + evenNumbers[i]);

         
        }

        ///

        List<int> myOneHunderdList = new List<int>();
        for(int i =0; i < myOneHunderdList.Count; i = i + 5)
        {

            Debug.Log( "Numbers divided by 5 ;" + myOneHunderdList[i]);

        }


        
        



    }
}
