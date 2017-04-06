using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BlocksPallete : MonoBehaviour {
	

	public GameObject start;


	
	// Prefab of section game object
	public GameObject sectionGameObject;

	[Header("Blocks")]

	// Motions Blocks
	public GameObject[] motionBlocks;

	// Flow Blocks
	public GameObject[] flowBlocks;

	// Logical Blocks
	public GameObject[] logicalBlocks;

	// Numbers Blocks
	public GameObject[] numbersBlocks;

	// Time Blocks
	public GameObject[] timeBlocks;

	// Use this for initialization
	void Start () {
		// Initialize the sections
		GameObject 	section;
		Text 		sectionTitle;
		ScrollRect 	sectionScrollRect;
		Transform 	sectionContentTransform;



		if(Application.loadedLevelName == "level1"){
		//	playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
	}


		// Motion
		section 				= Instantiate (this.sectionGameObject);
		sectionTitle 			= section.GetComponent<Text> ();
		sectionScrollRect 		= section.GetComponentInChildren<ScrollRect> ();
		sectionContentTransform	= sectionScrollRect.viewport.GetChild(0);

		sectionTitle.text = "Motion";
		foreach (GameObject motionGameObject in this.motionBlocks) {
			GameObject gameObject = Instantiate(motionGameObject);

			gameObject.transform.SetParent(sectionContentTransform, false);
		}
		section.transform.SetParent (this.gameObject.transform, false);

		// Flow
		section 				= Instantiate (this.sectionGameObject);
		sectionTitle 			= section.GetComponent<Text> ();
		sectionScrollRect 		= section.GetComponentInChildren<ScrollRect> ();
		sectionContentTransform	= sectionScrollRect.viewport.GetChild(0);
		
		sectionTitle.text = "Flow";
		foreach (GameObject flowGameObject in this.flowBlocks) {
			GameObject gameObject = Instantiate(flowGameObject);
			
			gameObject.transform.SetParent(sectionContentTransform, false);
		}
		section.transform.SetParent (this.gameObject.transform, false);

		// Logic
		section 				= Instantiate (this.sectionGameObject);
		sectionTitle 			= section.GetComponent<Text> ();
		sectionScrollRect 		= section.GetComponentInChildren<ScrollRect> ();
		sectionContentTransform	= sectionScrollRect.viewport.GetChild(0);
		
		sectionTitle.text = "Logic";
		foreach (GameObject logicGameObject in this.logicalBlocks) {
			GameObject gameObject = Instantiate(logicGameObject);
			
			gameObject.transform.SetParent(sectionContentTransform, false);
		}
		section.transform.SetParent (this.gameObject.transform, false);

		// Number
		section 				= Instantiate (this.sectionGameObject);
		sectionTitle 			= section.GetComponent<Text> ();
		sectionScrollRect 		= section.GetComponentInChildren<ScrollRect> ();
		sectionContentTransform	= sectionScrollRect.viewport.GetChild(0);
		
		sectionTitle.text = "Number";
		foreach (GameObject numberGameObject in this.numbersBlocks) {
			GameObject gameObject = Instantiate(numberGameObject);
			
			gameObject.transform.SetParent(sectionContentTransform, false);
		}
		section.transform.SetParent (this.gameObject.transform, false);

		// Time
		section 				= Instantiate (this.sectionGameObject);
		sectionTitle 			= section.GetComponent<Text> ();
		sectionScrollRect 		= section.GetComponentInChildren<ScrollRect> ();
		sectionContentTransform	= sectionScrollRect.viewport.GetChild(0);
		
		sectionTitle.text = "Time";
		foreach (GameObject timeGameObject in this.timeBlocks) {
			GameObject gameObject = Instantiate(timeGameObject);
			
			gameObject.transform.SetParent(sectionContentTransform, false);
		}
		section.transform.SetParent (this.gameObject.transform, false);
	}

	void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
    }

public void Play(){
        // Application.LoadLevel(1/*or whatever*/);
		         Debug.Log("You have clicked the button!");

     }

	 void Update(){

	//	   Ray rayC = Camera.main.ScreenPointToRay(Input.mousePosition);
    //    RaycastHit2D hit = Physics2D.GetRayIntersection(rayC, Mathf.Infinity);
/*        if (Input.GetMouseButtonDown(0) && hit.collider.name == "playButton")
        {
Debug.Log("click button");
Application.LoadLevel("level1");

		}*/

	
  /*    if (Input.GetMouseButtonDown(0)  && hit.collider.gameObject.name=="playButton")
        {
Debug.Log("click button");
Application.LoadLevel("level1");

		}*/
	 }

   public void onStartGame(){
Debug.Log("on start");
Application.LoadLevel("level1");

    }

	   public void onStartCode(){
Debug.Log("on start");
Application.LoadLevel("New");

    }
}
