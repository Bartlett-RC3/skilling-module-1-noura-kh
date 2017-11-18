using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeWork_Session4 : MonoBehaviour {

    public GameObject MyColumn;
    IEnumerator MyCouroutine;

    public Renderer rend;
    IEnumerator MyColorCouroutine;



    // Use this for initialization
    void Start () {

        MyCouroutine = DropColumns();
        MyColorCouroutine = ChangingColumnColor();

    }
	
	// Update is called once per frame
	void Update () {
        StartCoroutine (MyCouroutine);
        Debug.Log(Time.time);
        if (Time .time < 5)
        {
            StopCoroutine(MyCouroutine);
        }

        StartCoroutine(MyColorCouroutine);
        if (Time.time < 5)
        {
            
            StopCoroutine(MyColorCouroutine);

        }

	}

    //
    IEnumerator DropColumns()
    {
        while (true)
        {
            Vector3 ColumnPosition = new Vector3(Random.Range(0.0f, 0f), Random.Range(12f, 1.5f), Random.Range(0.0f, 0.0f));
            Quaternion ColumnRotation = new Quaternion(Random.Range(0, 90), Random.Range(0, 90), Random.Range(0, 90), 1);
            GameObject NewColumn = Instantiate(MyColumn, ColumnPosition, ColumnRotation);

            yield return new WaitForSeconds(5.0f);


        }


    }

    IEnumerator ChangingColumnColor()
    {
        while(true)
        {
            Color NewColor = new Color(255.0f, 0.0f, 0.0f);
            GameObject NewColoredColumn = Instantiate(MyColumn);
            yield return new WaitForSeconds(5.0f);


        }
        

    }





}
