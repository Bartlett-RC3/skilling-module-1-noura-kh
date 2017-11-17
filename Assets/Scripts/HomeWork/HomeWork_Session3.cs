using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeWork_Session3 : MonoBehaviour
{

    public GameObject MyCube;
    bool moveLeft = true;
    bool moveRight = false;
    int counter = 0;
    public Color GrayColor = Color.gray;
    public Color BlueColor = Color.blue;


    // Use this for initialization
    void Start()
    {

        


    }

    // Update is called once per frame
    void Update()
    {

        /*as i understood , this is a way to display in the consol the reptitve diplay of the frames but becuase the frame time
        depends on other factors such as CPU speed , the display of the reptitve frames called at aech update method is not
        constant in time and each frame has a diffrent duration for it to be displayed , therefor it can not be reilble to 
        count movment per frame .*/
        /*
        counter = counter + 1;
        if (counter % 6 == 00)
        {
            Debug.Log("Time in frame is  " + counter / 6);
        }
        
        // Time.delta Time allow us to show the real duration for each frame to form and display . The time in seconds it took to 
         complete the last frame. 

        Debug.Log("Actual time is " + Time.deltaTime.ToString()); */
        //Fisrt way to move the cube is by changing its position through accessing its position component :

        /*if (moveLeft == true)
        {
            if (counter <= 4)
            {
                this.gameObject.GetComponent<Transform>().position = new Vector3(counter * (-1), 0, 0);

                counter ++;
                Debug.Log("Pos of Cube when moveLeft is True is " + this.gameObject.transform.localPosition);
            }
            else
            {
                moveLeft = false;
                this.gameObject.GetComponent<Transform>().position = new Vector3(4, 0, 0);
                moveLeft = true;
                counter =0;
            }
        }
        //secound way to move the cube is to directly ask for it to move through the translation component :
        if (moveRight == true)
        {
            if (counter <= 4)
            {
                gameObject.transform.Translate(Vector3.left);

                counter ++;

            }
            else
            {
                moveRight = false;
                moveLeft = true;
                counter = 0;
            }
        }*/
        
        // Key board input:
        if (Input.GetKey(KeyCode.R))
        {
            gameObject.transform.Rotate(new Vector3(0, 2, 0));
        }

        if (Input.GetMouseButton(0))
        {
            gameObject.GetComponent<Renderer>().material.color = BlueColor;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = GrayColor;

        }








    }
}