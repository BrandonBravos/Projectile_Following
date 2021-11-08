using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject test_floor_grid;
    public GameObject target;


    public Transform spawn_transform;

    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        SpawnProjectile();
    }


    void SpawnProjectile()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject projectile_instance = Instantiate(projectile, spawn_transform.position, projectile.transform.rotation);
            projectile_instance.GetComponent<TrackingProjectile>().SetTarget(target.transform, 10.0f);
        
        }

    }

    void CreateFloorGrid() {

        int rows = 10;
        int columns = 10;

        Vector3 starting_grid_pos = new Vector3(-50, 0, -50);

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {

            //    Vector3 new_grid_pos = new Vector3((float)(r * 10), starting_grid_pos.y, starting_grid_pos.z);
            //Instantiate(test_floor_grid, new_grid_pos, test_floor_grid.transform.rotation);

        
                Vector3 new_grid_pos_z = new Vector3(starting_grid_pos.x + (r * 10), starting_grid_pos.y, starting_grid_pos.z + (c * 10));
                Instantiate(test_floor_grid, new_grid_pos_z, test_floor_grid.transform.rotation);


            }

        }




    }
}
