using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{

    public int bulletDamage=30;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Target"))
        {
            //print("hit"+collision.gameObject.name+"!");
            Destroy(gameObject);
        }
        if(collision.gameObject.CompareTag("Enemy"))
        {
            print("hit"+collision.gameObject.name+"!");
            collision.gameObject.GetComponent<Enemy>().TakeDamage(bulletDamage);
            Destroy(gameObject);
        }

    }
}
