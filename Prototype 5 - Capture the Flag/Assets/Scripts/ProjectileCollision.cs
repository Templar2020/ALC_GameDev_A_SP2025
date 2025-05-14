using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollision : MonoBehaviour
{

    public int  damage = 1;

    void OnCollisionEnter(Collision other)
    {
       Enemy enemy = other.gameObject.GetComponent<Enemy>();//Reference Enemy class and get enemy script component

       if(other.gameObject.CompareTag("Enemy") && enemy != null) //Check to see if we are hitting the enemy 
       {
         enemy.TakeDamage(damage);//Run the TakeDamage function and apply damage to enemy          
       }
             
    }
}
