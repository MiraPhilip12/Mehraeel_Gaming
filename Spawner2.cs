using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject bulletPrefab; // Drag the bullet prefab here in Inspector
    public float spawnForce = 5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Create a bullet at the spawner's position and rotation
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            // Add force if bullet has Rigidbody (optional)
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(transform.forward * spawnForce, ForceMode.VelocityChange);
            }
        }
    }
}
