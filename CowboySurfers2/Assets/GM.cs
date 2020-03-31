using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GM : MonoBehaviour {

    public static float vertVel = 0;
    public static int coinTotal = 0;
    public static float timeTotal = 0;
    public static float zVelAdj = 1;

    public float waitToLoad = 0;

    public static string lvlCompStatus = "";

    public Transform bbNoPit;
    public Transform bbPitMid;

    public float zScenePos = 60;

	// Use this for initialization
	void Start () {

        Instantiate(bbNoPit, new Vector3(0, 0, 20), bbNoPit.rotation);
        Instantiate(bbPitMid, new Vector3(0, 0, 40), bbPitMid.rotation);

        
    }
	
	// Update is called once per frame
	void Update () {
        if (zScenePos < 120)
        {
            Instantiate(bbNoPit, new Vector3(0, 0, zScenePos), bbNoPit.rotation);
            zScenePos += 20;
        }

        timeTotal += Time.deltaTime;
		
        if (lvlCompStatus == "fail")
        {
            waitToLoad += Time.deltaTime;
        }

        if (waitToLoad > 2)
        {
            SceneManager.LoadScene("LevelComplete");
        }
	}
}
