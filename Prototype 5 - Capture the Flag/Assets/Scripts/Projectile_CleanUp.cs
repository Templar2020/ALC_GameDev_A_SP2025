using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_CleanUp : MonoBehaviour
{

    public int countDown = 3;

    // Start is called before the first frame update
    void Start()
    {
       Destroy(gameObject, countDown); //Self Destruct in X number of seconds 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
