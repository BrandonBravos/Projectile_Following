using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingProjectile : MonoBehaviour
{

    // use this to designate a target that the projectile will follow
   public Transform target;

    // the speed in which the projectile will move
   public float speed = 1.0f; 


    // Update is called once per frame
    void Update()
    {
        // this is used to follow the target
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    // after instantiating the projectile call this function
    public void SetTarget(Transform target_to, float projectile_speed)
    {
        speed = projectile_speed;
        target = target_to;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

    
}
