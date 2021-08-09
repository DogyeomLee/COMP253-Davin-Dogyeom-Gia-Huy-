using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rigid;

    public Animator animator;

    public float Speed; 

    public float rotateSpeed;

    float h, v;  

    void Start() 
    { 
        rigid = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    } 
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector3.up * Speed, ForceMode.Impulse);
            animator.SetBool("Jump", true);
            animator.SetBool("Attack", false);
            animator.SetBool("Walk", false);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetBool("Jump", false);
            animator.SetBool("Crouch", true);
            animator.SetBool("Attack", false);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            animator.SetBool("Crouch", false);
            animator.SetBool("Attack", true);
            animator.SetBool("Jump", false);
        }
        else
        {
            animator.SetBool("Attack", false);
            animator.SetBool("Crouch", false);
            animator.SetBool("Jump", false);
        }
        
    } 

    
    void FixedUpdate() 
    { 
        
       
        h = Input.GetAxis("Horizontal"); 
        v = Input.GetAxis("Vertical"); 
        Vector3 dir = new Vector3(h, 0, v);
        
        if (!(h == 0 && v == 0)) 
        {
            animator.SetBool("Walk", true);

            transform.position += dir * Speed * Time.deltaTime; 
          
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * rotateSpeed); 
        } 
        else
        {
            animator.SetBool("Walk", false);
        }
    } 
}

