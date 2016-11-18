using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    CharacterController charter;
    public float speed;
    Animator anim;
    public GameObject Enemy;
	void Start ()
    {
        charter = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
	}
	
	
	void Update ()
    {
       // float h = Input.GetAxis("Horizontal");
       // float mh = Input.GetAxis("Mouse Y");
       // float v = Input.GetAxis("Vertical");
       // float mv = Input.GetAxis("Mouse X");

        int walk = Mathf.RoundToInt(Input.GetAxis("Vertical"));
        int strafe = Mathf.RoundToInt(Input.GetAxis("Horizontal"));
        // anim.SetInteger("Walk", walk);
        //anim.SetInteger("Strafe", strafe);

        //if (h != 0)
        // charter.Move(transform.right * h * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
        {
            charter.Move(transform.forward * speed * Time.deltaTime);
            anim.SetBool("Walk Forward", true);
        }
        else
            anim.SetBool("Walk Forward", false);
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("Walk Backward", true);
            charter.Move(-transform.forward * speed * Time.deltaTime);
        }
        else
             anim.SetBool("Walk Backward", false);
        if (Input.GetButtonDown("Jump"))
        {
            anim.SetBool("PunchTrigger", true);
        }
        else
            anim.SetBool("PunchTrigger", false);
    }



}
