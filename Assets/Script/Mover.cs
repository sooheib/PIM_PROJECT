using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {
    Vector3 moveForward= new Vector3(0, 0, 0.1f);
    Vector3 jump = new Vector3(0, 0.2f, 0.1f);
    public static ArrayList actions = new ArrayList() ;
    bool executed;
    float step;
    Animator animator;
	// Use this for initialization
	void Start () {
        executed = false;
        step = transform.position.x-1;
        animator = GetComponent<Animator>();        
        StartCoroutine(moves());
        Debug.Log(actions.Count);

    }
	
	// Update is called once per frame
	void Update () {
        //animator.SetBool("walking", true);
        
        //executeCommands(actions);
        //transform.Translate(moveTest);

    }

    void executeCommands(int[] actions)
    {
        
        foreach (int action in actions)
        {
            
           
        }

        }
    

    void movePlayer(Vector3 direction)
    {

        transform.Translate(direction*Time.deltaTime*10);
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
                            yield return new WaitForSeconds(0.01f);
                            movePlayer(moveForward);

                        }


                        break;
                    case 2:
                        animator.SetBool("jump", true);
                        for (int i = 0; i < 30; i++)
                        {
                            yield return new WaitForSeconds(0.001f);
                            movePlayer(jump);

                        }
                        break;
                    case 3:
                        animator.SetBool("turnRight", true);

                        for (int i = 0; i < 30; i++)
                        {
                            yield return new WaitForSeconds(0.001f);
                            transform.Rotate(new Vector3(0,3    , 0));

                        }
                        break;
                    case 4:
                        animator.SetBool("turnLeft", true);

                        for (int i = 0; i < 30; i++)
                        {
                            yield return new WaitForSeconds(0.001f);
                            transform.Rotate(new Vector3(0, -3, 0));

                        }
                        break;
                    case 5:
                        animator.SetBool("dance", true);
                        
                        break;
                }
                /*if (action.name=="blueButton2")
                {
                    animator.SetBool("walking", true);
                    for (int i = 0; i < 30; i++)
                    {
                        yield return new WaitForSeconds(0.01f);
                        movePlayer(moveForward);

                    }
                }
                else if (action.name == "redButton2")
                {
                    animator.SetBool("turnRight", true);

                    for (int i = 0; i < 30; i++)
                    {
                        yield return new WaitForSeconds(0.001f);
                        transform.Rotate(new Vector3(0, 3, 0));

                    }
                }
                else if (action.name == "yellowButton2")
                {
                    animator.SetBool("dance", true);
                }
                else if (action.name == "greenButton2")
                {
                    for (int i = 0; i < 30; i++)
                    {
                        yield return new WaitForSeconds(0.001f);
                        movePlayer(jump);

                    }
                }
                else if (action.name == "pinkButton2")
                {
                    animator.SetBool("turnLeft", true);

                    for (int i = 0; i < 30; i++)
                    {
                        yield return new WaitForSeconds(0.001f);
                        transform.Rotate(new Vector3(0, -3, 0));

                    }
                }*/

                animator.SetBool("walking", false);
                animator.SetBool("jump", false);
                animator.SetBool("turnLeft", false);
                animator.SetBool("turnRight", false);
                yield return new WaitForSeconds(1.0f);
            }
            executed = true;
            

        }
    }


}
