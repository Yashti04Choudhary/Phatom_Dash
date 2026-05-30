using UnityEngine;

public class BackgroundFollow : MonoBehaviour
{
    public Transform cameraTarget;
    public float distance = 350f;

    void Update()
    {
        Vector3 pos = transform.position;
        pos.z = cameraTarget.position.z + distance;
        transform.position = pos;
    }
}
