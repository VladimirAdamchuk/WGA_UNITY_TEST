using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour
{
    public int CurHealth = 100;
    private bool die;
    public Transform[] elements;
   // public Transform[] items;
    public Enemy Damage;
    void Start()
    {

    }
    void Update()
    {
        if (CurHealth <= 0 & die == false)
        {
            die = true;
            Die();
        }
    }
    void Die() // смерть врага и отключение is Kinematic 
    {
        
        foreach (Transform body in elements)
        {
            body.GetComponent<Rigidbody>().isKinematic = false;
        }
        transform.GetComponent<Animator>().enabled = false;
        Invoke("DropWeapon", 0.2f);
        Damage.damage();
    }
    void OnTriggerEnter()
    {

    }
}
