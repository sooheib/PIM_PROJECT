using UnityEngine;
using System.Collections;

public class Drop : MonoBehaviour {
	private GameObject gameManager ;
    GameObject instance;
	InstantiateBlocks instantiateBlocks = new InstantiateBlocks ()  ;
	 // public GameObject box;
	Vector3 postionInitial ;
	// Use this for initialization
	void Start () {
		postionInitial = transform.position;
		gameManager = (GameObject)GameObject.FindGameObjectWithTag ("GameManager");
		instantiateBlocks =   gameManager.GetComponent<InstantiateBlocks> ();
       

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void  OnTriggerStay2D (Collider2D coll)  
	{
        // boutton avec tag (blue,red,green,yellow,pink) dropped dans workspace
        if (coll.tag == "WorkSpace" + "" && Input.GetMouseButtonUp(0) && (gameObject.tag == "blue" || gameObject.tag == "green" || gameObject.tag == "red" || gameObject.tag == "pink" || gameObject.tag == "yellow"))
        {
            //créer une instance de l'objet  à la position ou on relache le boutton 
            instance = (GameObject)Instantiate(gameObject, transform.position, transform.rotation);
            //tag de l'instance se nommera block 
            instance.tag = "block";
            //l'objet retourne à sa position initial 
            transform.position = postionInitial;



        }



        //boutton en collision avec le dernier boutton de la list  
     else    if (coll.tag == instantiateBlocks.move.Count - 1 + "" && Input.GetMouseButtonUp(0))
        {
            // boutton avec tag (blue,red,green,yellow,pink)
            if (gameObject.tag == "blue" || gameObject.tag == "green" || gameObject.tag == "red" || gameObject.tag == "pink" || gameObject.tag == "yellow")
            {
                instance = (GameObject)Instantiate(gameObject, new Vector2(coll.transform.position.x, coll.transform.position.y - 0.7f), coll.transform.rotation);
                // tag = position de l'instance dans la list
                instance.tag = instantiateBlocks.move.Count + "";
          
            //coll est le parent du dernier boutton ajouté <=> faire le drag and drop d'un objet parent engendra le mouvement des objets fils 
            instance.transform.SetParent(coll.transform);
            // ajouter l'instance dans la list 
            instantiateBlocks.move.Add(instance);
            
            }

            // boutton avec tag block
            else 
            {
            
            gameObject.tag = instantiateBlocks.move.Count + "";
            // position de boutton = en dessous de coll 
            gameObject.transform.position = new Vector2(coll.transform.position.x, coll.transform.position.y - 0.7f);
            //coll est le parent du dernier boutton ajouté <=> faire le drag and drop d'un objet parent engendra le mouvement des objets fils 
            gameObject.transform.SetParent(coll.transform);
            // ajouter l'objet dans la list 
            instantiateBlocks.move.Add(gameObject);
           // Debug.Log(gameObject.name);
            }
        }




        // boutton avec tag !(blue,red,green,yellow,pink) exemple block ou un numero  dropped dans blockspace
        // blockspace est desactivé dans l'inspector 
     else    if (coll.tag == "blockSpace" && Input.GetMouseButtonUp(0)&&(gameObject.tag != "blue" && gameObject.tag != "green" && gameObject.tag != "red" && gameObject.tag != "pink" && gameObject.tag != "yellow"))
        {
            // detruire l'objet 
             Destroy(gameObject);





       }


    }


}