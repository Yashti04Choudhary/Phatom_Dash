using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed = 16f;
    public float maxSpeed = 28f;
    public float laneDistance = 2f;
    public float laneChangeSpeed = 10f;
    public int CurrentLane => currentLane;

    private int currentLane = 0;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.interpolation = RigidbodyInterpolation.Interpolate;
        rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;

        Time.timeScale = 1.2f;
    }

    void FixedUpdate()
    {
        //  TARGET X POSITION FOR LANES
        float targetX = currentLane * laneDistance;

        //  Calculate sideways velocity toward lane
        float xVelocity = (targetX - rb.position.x) * laneChangeSpeed;

        //  REAL PHYSICS MOVEMENT (NO MovePosition)
        rb.velocity = new Vector3(
            xVelocity,
            rb.velocity.y,
            forwardSpeed
        );

        // Speed increase with cap
        forwardSpeed += Time.fixedDeltaTime * 0.3f;
        forwardSpeed = Mathf.Clamp(forwardSpeed, 0f, maxSpeed);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            ChangeLane(-1);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            ChangeLane(1);
        }
    }

    void ChangeLane(int direction)
    {
        currentLane += direction;
        currentLane = Mathf.Clamp(currentLane, -1, 1);
    }
}
