using UnityEngine;
using System.Collections;


public class Success : MonoBehaviour {


	public	bool win ;

	// Use this for initialization
	void Start () {
		win = false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void  OnTriggerStay (Collider coll)  
	{

		if (coll.tag=="lampe")
		{



			win = true;
			Destroy (coll.gameObject);




		}




	}
}
