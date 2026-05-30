using UnityEngine;

public class ObstacleLogic : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private float[] lanes = { -2f, 0f, 2f };

    void Start()
    {
        // SAFE START ZONE (no obstacles near player)
        if (transform.position.z < 25f) return;

        int randomIndex = Random.Range(0, lanes.Length);
        float spawnX = lanes[randomIndex];

        Vector3 localPos = new Vector3(spawnX, 0.5f, 0f);

        if (obstaclePrefab.Length > 0)
        {
            int randomObstacle = Random.Range(0, obstaclePrefab.Length);

            GameObject newObstacle =
                Instantiate(obstaclePrefab[randomObstacle], transform);

            newObstacle.transform.localPosition = localPos;
        }
    }
}