using UnityEngine;
using System.Collections;

public class DragDrop : MonoBehaviour {

	private Vector3 pos;
	public bool vole = true  ;
	private Vector3 screenPos;
	private Vector3 currentScreenPos;
	private Vector3 currentPos;
	private Vector3 lastPosition;
	private Vector3 lastPos;
    private Vector3 firstPos;
    private Vector3 offset;
	private Vector3 dir;
	public float moveSpeed;
	private CharacterController controller;
   


    void Start () {
        firstPos = gameObject.transform.position;
	}


	void Update(){
		MoveUpdate();
	}

	void MoveUpdate(){   


		if(vole){
			if (Application.platform == RuntimePlatform.Android){

				pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 0));
			}
			else{

				pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
				lastPos = pos;
			}
		}

		if (Input.touchCount == 1) {    

			Touch f0 = Input.GetTouch(0);
			Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit, 100)) {

				//On vérifie que l'on clique bien sur la fée     
				//if(hit.collider.tag == "blue"||hit.collider.tag == "green"||hit.collider.tag == "red"||hit.collider.tag == "pink"||hit.collider.tag == "yellow"){
					if (f0.phase == TouchPhase.Began) {
						screenPos = Camera.main.WorldToScreenPoint(transform.position);
						offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(f0.position.x, f0.position.y, 0));   
					}else if(f0.phase == TouchPhase.Moved){

						currentScreenPos = new Vector3(f0.position.x, f0.position.y,0);
						currentPos = Camera.main.ScreenToWorldPoint(currentScreenPos) + offset;
						transform.position = currentPos;
						lastPosition = currentPos;
					//}
				}
			}




		} 



	}

	void OnMouseDrag() {
        //changer le position de l'objet
  transform.position = new Vector3(pos.x,pos.y,0);    
	}

   // void OnTriggerStay2D(Collider2D coll)
  //  {

       // if (coll.tag == "blockSpace" && Input.GetMouseButtonUp(0))
      //  {

      //      gameObject.transform.position = firstPos;



      //  }




   // }

    //void OnCollisionEnter(Collision collision)
    //{
    //	StartCoroutine("collisionFee");
    //
    //}
    /*
       void OnTriggerEnter(Collider other) {
       
             StartCoroutine("collisionFee");
         
     }
     */
    //	IEnumerator collisionFee() {
    //	vole = false;
    //	transform.position = lastPosition;
    //	transform.position = new Vector3(lastPos.x,lastPos.y,0);
    //	yield return new WaitForSeconds(1f);
    //	vole = true;
    //}
}
