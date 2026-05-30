using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;

    // Updated to match your lane distance of 0.6
    private float[] lanePositions = { -0.6f, 0f, 0.6f };

    void Start()
    {
        // We only spawn once when the segment is created
        SpawnObstacle();
    }

    void SpawnObstacle()
    {
        if (obstaclePrefab == null) return;

        // 1. Pick a random lane (0, 1, or 2)
        int laneIndex = Random.Range(0, lanePositions.Length);

        // 2. Set the position. 
        // We use localPosition so it stays perfectly on the road segment it belongs to.
        Vector3 spawnPosition = new Vector3(lanePositions[laneIndex], 0.5f, 0f);

        // 3. Spawn the obstacle as a CHILD of this segment.
        // This way, when the segment is deleted, the obstacle is deleted too!
        GameObject newObstacle = Instantiate(obstaclePrefab, transform);
        newObstacle.transform.localPosition = spawnPosition;
    }
}