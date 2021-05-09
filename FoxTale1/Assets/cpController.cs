using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cpController : MonoBehaviour
{
    public static cpController instance;
    private checkpoint[] checkpoints;
    public Vector3 spawnPoint;

    public void SetSpawnPoint(Vector3 newSpawnPoint)
    {
        spawnPoint = newSpawnPoint;
    }

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        checkpoints = FindObjectsOfType<checkpoint>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeactivateCp()
    {
        for (int i=0; i< checkpoints.Length; i++)
        {
            checkpoints[i].Reset();
        }
    }
}
