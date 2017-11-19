using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeWork_Session4_RayCasting : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Ray Direction:

        Vector3 CastedRayDirection = transform.TransformDirection(Vector3.right);
        
        RaycastHit TargetObject;

        //An attempt was made to change teh color of the target cube after it has been hit with the ray , but it was not succesful:     
        /*Renderer rend = GetComponent<Renderer>();
        Color TargetObjectColor = TargetObject.transform<Renderer>(Color .red);*/
        
    

     
   

        //RayCasting :

        if (Physics.Raycast(transform.position, CastedRayDirection, out TargetObject ))
        {

            string TargetObjectName = TargetObject.transform.name;
            Debug.Log("There is an object infront of me , its name is  " + TargetObjectName);
            Destroy(TargetObject.transform.gameObject);
            


        }

        if (Input.GetMouseButton(0))
        {
            transform.Translate(Vector3.up * 0.1f);
        }

        if (Input.GetMouseButton(1))
        {
            transform.Translate(Vector3.down * 0.1f);
        }




    }

    









}
