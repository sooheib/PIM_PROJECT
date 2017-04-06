using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mover : MonoBehaviour {
    Vector3 moveForward= new Vector3(0, 0, 0.3f);
    Vector3 jump = new Vector3(0, 0.2f, 0.03f);
    	public Text name_text;
	private string textName="selmi";
    public static ArrayList actions = new ArrayList() ;
    bool executed;
    //Success success = new Success ()  ;
    float step;
    Animator animator;
	
//	public GameObject winUi ;
	// Use this for initialization
	void Start () {
        executed = false;

        //   winUi = (GameObject)GameObject.FindGameObjectWithTag ("WinUi");
        //success =   GetComponent<Success> ();
       /* actions.Add(1);
        actions.Add(1);
        actions.Add(1);
        actions.Add(1);
        actions.Add(1);
        actions.Add(4);
        actions.Add(1);
        actions.Add(1);*/

        
       //actions.Add(2);
     //   actions.Add(1);
       // actions.Add(1);
    //    actions.Add(1);

    //    actions.Add(4);
   //     actions.Add(1);
        

        animator = GetComponent<Animator>();        
        StartCoroutine(moves());
        Debug.Log(actions.Count);

    }
	
	// Update is called once per frame
	void Update () {
		//if (executed )

name_text.text=textName;


		//{
		//	if (success.win)

			//	Instantiate (winUi, new Vector3(-1.26f,3.244f,8.943f),Quaternion.identity);

			//else if (!success.win)
		//		Debug.Log ("fail");

		//}



    }

    
  /*  voidChangeCode(){
        name_text.text=name_text.text+" ";
    }
*/
    void movePlayer(Vector3 direction)
    {
       
    transform.Translate(direction*0.21f);
    }
    IEnumerator moves()
    {
        while (!executed)
        {
            foreach (int action in actions)
            {
                switch (action)
                {
                    case 1:
                        animator.SetBool("walking", true);
                        for (int i=0;i<30;i++)
                        {
                              textName="forward";
                              Debug.Log(textName);
                            yield return new WaitForSeconds(0.01f);
                               movePlayer(moveForward);
                             //  textName="forward";
                               // Debug.Log(textName);
                               //name_text.text=textName;
                        }


                        break;
                    case 2:
                        animator.SetBool("jump", true);
                        for (int i = 0; i < 30; i++)
                        {
                            yield return new WaitForSeconds(0.001f);
                            movePlayer(jump);

                            textName="jump";
                              Debug.Log(textName);
                         
                        }
                        break;
                    case 3:
                        animator.SetBool("turnRight", true);

                        for (int i = 0; i < 30; i++)
                        {
                            textName="turnRight";
                              Debug.Log(textName);
                            yield return new WaitForSeconds(0.001f);
                            transform.Rotate(new Vector3(0,3    , 0));

                        }
                        break;
                    case 4:
                        animator.SetBool("turnLeft", true);

                        for (int i = 0; i < 30; i++)
                        {
                            textName="turnLeft";
                              Debug.Log(textName);
                            yield return new WaitForSeconds(0.001f);
                            transform.Rotate(new Vector3(0, -3, 0));

                        }
                        break;
                    case 5:
                    textName="Running";
                              Debug.Log(textName);
                        animator.SetBool("running", true);
                        
                        break;
                }
                
                

                animator.SetBool("walking", false);
               // animator.SetBool("jump", false);
                animator.SetBool("turnLeft", false);
                //animator.SetBool("turnRight", false);
                animator.SetBool("running", false);
                yield return new WaitForSeconds(1.0f);
            }
            executed = true;
            

        }
    }


}
