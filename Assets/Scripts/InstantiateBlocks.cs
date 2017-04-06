﻿using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

public class InstantiateBlocks : MonoBehaviour {
	public GameObject start;
	public GameObject  [] action ;
	public ArrayList  move = new ArrayList();   
	// Use this for initialization
	void Start () {
		for(int i = 0 ; i<action.Length ;i++ )
			Instantiate (action[i], action[i].transform.position,action[i].transform.rotation);
		move.Add (start);
        

        
            

    }

    // Update is called once per frame
    void Update () {
        Ray rayC = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.GetRayIntersection(rayC, Mathf.Infinity);
        if (Input.GetMouseButtonDown(0) && hit.collider.name == "playButton")
        {
            foreach (GameObject action in move)
            {
    
                if (action.name == "bluebutton")
                {
                    Debug.Log("aaaaaaaa");
                    Mover.actions.Add(1);
                }
                else if (action.name == "redButton")
                {
                    Mover.actions.Add(3);
                }
                else if (action.name == "yellowButton")
                {
                    Mover.actions.Add(5);
                }
                else if (action.name == "greenButton")
                {
                    Mover.actions.Add(2);
                }
                else if (action.name == "pinkButton")
                {
                    Mover.actions.Add(4);
                }
            }
                SceneManager.LoadScene("level1");

        }
    }


}