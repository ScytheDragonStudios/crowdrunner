using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ChunkManager : MonoBehaviour
{
    [Header(" Header ")]
    [SerializeField] private Chunk[] chunksPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 chunkPosition = Vector3.zero;

        for (int i = 0; i < 5; i++)
        {
            Chunk chunkToCreate = chunksPrefabs[Random.Range(0, chunksPrefabs.Length)];

            if (i > 0)
            {
                chunkPosition.z += chunkToCreate.GetLength() / 2;
            }

            Chunk chunkInstance = Instantiate(chunkToCreate, chunkPosition, Quaternion.identity, transform);

            chunkPosition.z += chunkInstance.GetLength() / 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
