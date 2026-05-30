using UnityEngine;
using System.Collections.Generic;

public class SegmentSpawner : MonoBehaviour
{
    public GameObject[] segmentPrefabs;
    public Transform player;

    public float segmentLength = 10f;
    public int segmentsAhead = 6;      // keep a safe value
    public int initialSegments = 3;

    private float spawnZ = 0f;
    private float safeZone = 2f;

    private int lastPrefabIndex = -1;
    private List<GameObject> activeSegments = new List<GameObject>();

    void Start()
    {
        spawnZ = player.position.z;

        for (int i = 0; i < initialSegments; i++)
        {
            SpawnSegment();
        }
    }

    void Update()
    {
        // OLD SIMPLE DISTANCE-BASED SPAWNING
        if (player.position.z + (segmentsAhead * segmentLength) > spawnZ - safeZone)
        {
            SpawnSegment();
            DeleteOldSegment();
        }
    }

    void SpawnSegment()
    {
        int randomIndex = Random.Range(0, segmentPrefabs.Length);

        while (randomIndex == lastPrefabIndex && segmentPrefabs.Length > 1)
        {
            randomIndex = Random.Range(0, segmentPrefabs.Length);
        }

        lastPrefabIndex = randomIndex;

        Vector3 spawnPos = new Vector3(0, 0, spawnZ);

        GameObject segment =
            Instantiate(segmentPrefabs[randomIndex], spawnPos, Quaternion.identity);

        activeSegments.Add(segment);

        spawnZ += segmentLength;
    }

    void DeleteOldSegment()
    {
        if (activeSegments.Count > initialSegments)
        {
            Destroy(activeSegments[0]);
            activeSegments.RemoveAt(0);
        }
    }
}