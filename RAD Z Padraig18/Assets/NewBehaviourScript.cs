using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
      animator = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
       animator.SetBool("Is Running", false);
       if (Input.GetKey(KeyCode.W))
   
       {
            transform.position += transform.forward * Time.deltaTime;
            animator.SetBool("Is Running", true);
       
       }

       if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.down, 65 * Time.deltaTime);

       if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, 65 * Time.deltaTime);

       if (Input.GetKey(KeyCode.S))
            transform.position += Vector3.back * Time.deltaTime;

       if (Input.GetKey(KeyCode.Q))
            transform.position +=Vector3.left * Time,deltaTime;
}
