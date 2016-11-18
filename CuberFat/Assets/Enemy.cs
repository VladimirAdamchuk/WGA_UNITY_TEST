using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public GameObject Player;
    NavMeshAgent agent;
    Animator animator;
    public float speed;
    public float HP;
    public float SP;
	void Start ()
    {
        
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        
	}
    void move()
    {
        
        agent.destination = Player.transform.position;
        Invoke("move", 2f);
    }


    void Update()
    {
        agent.destination = Player.transform.position;
        float distanse = Vector3.Distance(transform.position, Player.transform.position);

        if (distanse < 1.5f)
        {
            animator.SetTrigger("PunchTrigger");
            agent.speed = 0;
            Invoke("move", 2f);
        }
        else
            agent.speed = speed;

        if (agent.velocity.magnitude > 1)
        {
            animator.SetBool("Walk Forward", true);
        }
        else
            animator.SetBool("Walk Forward", false);
    }

    public void damage()
    {
        //to do
    }
}
