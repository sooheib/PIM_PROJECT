using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ABCText : MonoBehaviour {

	public Text name_text;
	private string textName="souheib";


	 //Vector3 moveForward= new Vector3(0, 0, 0.3f);
   // Vector3 jump = new Vector3(0, 0.2f, 0.03f);
    public static ArrayList actions = new ArrayList() ;
    bool executed=false;
    //Success success = new Success ()  ;
  //  float step;
    //Animator animator;
	
	//public GameObject winUi ;

	// Use this for initialization
	void Start () {
	//name_text.text=textName;
	       // executed = false;



	}
	
	// Update is called once per frame
	void Update () {

		//moves();
//	name_text.text=textName;


	
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
                       // animator.SetBool("walking", true);
                        for (int i=0;i<30;i++)
                        {
							Debug.Log("11111");
                            yield return new WaitForSeconds(0.01f);
							
                              // movePlayer(moveForward);
							  //textName="forward";
						textName=textName+" "+"forward";
                        Debug.Log("forward");
						//name_text.text=textName;
						//return textName;
                        }


                        break;
                    case 2:
                      //  animator.SetBool("jump", true);
                        for (int i = 0; i < 30; i++)
                        {
                         //    name_text=name_text+ "   "+ "fll";
						textName=textName+" "+"forward";
						                            yield return new WaitForSeconds(0.01f);

                         
                        }
                        break;
                    case 3:
                     //   animator.SetBool("turnRight", true);

                        for (int i = 0; i < 30; i++)
                        {
        //   name_text=name_text+ "   "+ "for";
						textName=textName+" "+"forward";
						                            yield return new WaitForSeconds(0.01f);


                        }
                        break;
                    case 4:
                       // animator.SetBool("turnLeft", true);

                        for (int i = 0; i < 30; i++)
                        {
                     //   name_text=name_text+ "   "+ "forwajjjjjrd";
						textName=textName+" "+"forward";
						                            yield return new WaitForSeconds(0.01f);


                        }
                        break;
                    case 5:
                       // animator.SetBool("running", true);
					 //   name_text=name_text+ "   "+ "forwardjj";
						textName=textName+" "+"forward";
                                                    yield return new WaitForSeconds(0.01f);

                        break;
                }
                
                

               // animator.SetBool("walking", false);
               // animator.SetBool("jump", false);
               // animator.SetBool("turnLeft", false);
                //animator.SetBool("turnRight", false);
               // animator.SetBool("running", false);
               // yield return new WaitForSeconds(1.0f);
            }
            executed = true;
            

        }
    }

}
