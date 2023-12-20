using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int attackDamage = 10;
    public Vector2 knockback = Vector2.zero;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageAble damageAble = collision.GetComponent<DamageAble>();

        if(damageAble != null )
        {
            bool gotHit = damageAble.Hit(attackDamage, knockback);

            if(gotHit)
                Debug.Log(collision.name + "hit for " + attackDamage);
        }
    }
}
