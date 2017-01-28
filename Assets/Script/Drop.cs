using UnityEngine;
using System.Collections;

public class Drop : MonoBehaviour {
	public GameObject action;
	private GameObject gameManager ;
	Instantiate1 instantiate = new Instantiate1 ()  ;
	 // public GameObject box;
	Vector3 postionInitial ;
	// Use this for initialization
	void Start () {
		postionInitial = transform.position;
		gameManager = (GameObject)GameObject.FindGameObjectWithTag ("GameManager");
		instantiate =   gameManager.GetComponent<Instantiate1> ();


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void  OnTriggerStay2D (Collider2D coll)  
	{

		if (coll.tag==instantiate.move.Count-1+""  &&Input.GetMouseButtonUp(0))
		{
			
			 

			transform.position = postionInitial;
			action.tag = instantiate.move.Count+"";
			GameObject instance= (GameObject)	Instantiate (action,new Vector2 ( coll.transform.position.x,coll.transform.position.y-0.7f), coll.transform.rotation);
			instance.transform.SetParent (coll.transform);  
			instantiate.move.Add (action);
            


		
		
		}




	}


}