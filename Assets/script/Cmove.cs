
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cmove : MonoBehaviour
{
    Animator anim;
    SpriteRenderer rend;
    public float speed = 4.0f;



    void Start()
    {

        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();

    }

    void Update()
    {
        Movement();
        anim.SetFloat("run", speed);


        if (Input.GetKey(KeyCode.D))
        {
            speed = speed + Time.deltaTime;
            anim.SetBool("walking", true);
           

        }
        else if (Input.GetKey(KeyCode.A))
        {
            speed = speed + Time.deltaTime;
            anim.SetBool("walking", true);

        }
        else if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("Jump", true);

        }
        else if (Input.GetKey(KeyCode.K))
        {
            anim.SetBool("attack", true);
            speed = 4.0f;
        }
        else if (Input.GetKey(KeyCode.C))
        {
            anim.SetBool("Crouch", true);
            speed = 4.0f;
        }
        else
        {
            speed = 4.0f;
            anim.SetBool("walking", false);
            anim.SetBool("Jump", false);
            anim.SetBool("attack", false);
            anim.SetBool("Crouch", false);

        }
   




    }
    

    void Movement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
            rend.flipX = false;
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
            rend.flipX = true;
            
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector2.up * 10f * Time.deltaTime);          
        }
        if (Input.GetKey(KeyCode.C))
        {
           
        }

    }
}
