using UnityEngine;
using System.Collections;

public class InputDamage : MonoBehaviour
{
    public EnemyHealth hp;
    public int multipler;
    public void Hit(int damage)
    {
        hp.CurHealth -= damage * multipler;
        Debug.Log(damage * multipler);
    }
}
