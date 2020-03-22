using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSphere : MonoBehaviour {

    public KeyCode moveL;
    public KeyCode moveR;

    public float horizVel = 0;
    public int laneNum = 2;
    public string controlLocked = "n";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, 0, -4);

        if (Input.GetKeyDown(moveL) && laneNum < 3 && controlLocked == "n")
        {
            horizVel = 2;
            StartCoroutine(stopSlide());
            laneNum++;
            controlLocked = "y";
        }



        if (Input.GetKeyDown(moveR) && laneNum > 1 && controlLocked == "n")
        {
            horizVel = -2;
            StartCoroutine(stopSlide());
            laneNum--;
            controlLocked = "y";
        }

    }

    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(.5f);
        horizVel = 0;
        controlLocked = "n";
    }
}
