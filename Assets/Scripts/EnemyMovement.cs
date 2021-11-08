using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform enemy_transform;
  

    public Transform starting_transform;
    public Transform ending_transform;


    private bool reached_destination = true;




    // Movement speed in units per second.
    public float min_speed = 10.0f;
    public float max_speed = 16.0f;

    private float speed = 0.0f;


    private Vector3 enemy_starting_pos;
    private Vector3 random_movement_v3;

    // Start is called before the first frame update
    void Start()
    {
        enemy_starting_pos = transform.position;

        enemy_transform = GetComponent<Transform>();
        enemy_transform.position = starting_transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        RandomMovement();

    }

    void RandomMovement() {
        float x_range = 10.0f;
        float y_range = 5.0f;
        float z_range = 10.0f;


        if (reached_destination)
        {
            random_movement_v3 = new Vector3(enemy_starting_pos.x + Random.Range(-x_range, x_range), enemy_starting_pos.y + Random.Range(0.5f, y_range), enemy_starting_pos.z + Random.Range(-z_range, z_range));
            reached_destination = false;
            speed = Random.Range(min_speed, max_speed);
        }
        else {
            transform.position = Vector3.MoveTowards(transform.position, random_movement_v3, speed * Time.deltaTime);
            if (transform.position == random_movement_v3) {
                reached_destination = true;
                    }
        }
         

        

        

    }
}
