using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{

    Animator anim;
    public GameObject target;
    NavMeshAgent agent;

    enum STATE {IDLE, WANDER, ATTACK, CHASE, DEAD};
    STATE state = STATE.IDLE;

    
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
        agent = this.GetComponent<NavMeshAgent>();
        anim.SetBool("isWalking", true);
    }

    void TurnOffTriggers()
    {
        anim.SetBool("isWalking",false);
        anim.SetBool("isAttacking",false);
        anim.SetBool("isRunning",false);
        anim.SetBool("isDead",false);
      

    }
    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case STATE.IDLE:
                state = STATE.WANDER;
            break;
            case STATE.WANDER:
                if(!agent.hasPath)
                {
                    float newX = this.transform.position.x + Random.Range(-5,5);
                    float newZ = this.transform.position.z + Random.Range(-5,5);
                    float newY = Terrain.activeTerrain.SampleHeight(new Vector3(newX,0,newZ));
                    Vector3 dest = new Vector3(newX,newY,newZ);
                    agent.SetDestination(dest);
                    agent.stoppingDistance = 0;
                    TurnOffTriggers();
                    anim.SetBool("isWalking",true);
                }
                
            break;
            case STATE.CHASE:
            break;
            case STATE.DEAD:
            break;
        }
            
        
        
    }

}
