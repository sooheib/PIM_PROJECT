using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void  OnTriggerStay2D (Collider2D coll)  
	{

		if ((coll.tag!="blue" &&coll.tag!="pink"&&coll.tag!="red"&&coll.tag!="green"&&coll.tag!="yellow")&& Input.GetMouseButtonUp(0) )
		{


		
			Destroy (coll.gameObject);
		
		}




	}


}
