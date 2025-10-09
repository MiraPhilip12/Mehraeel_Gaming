using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    public Transform spawnPoint;
    public isSpawned = false;
    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space) && !isSpawned)
        {
            Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
            isSpawned = true;
        }
    }
}
