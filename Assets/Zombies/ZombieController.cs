using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking",false);
        }
        if(Input.GetKey(KeyCode.Mouse0))
        {
            anim.SetBool("isAttacking",true);
        }
        else
        {
            anim.SetBool("isAttacking", false);
        }
        if(Input.GetKey(KeyCode.K))
        {
            anim.SetBool("isDeath", true);
        }
        if(Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
    }

}
