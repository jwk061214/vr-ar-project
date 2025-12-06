using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float mvSpeed = 5f;
    public float rotSpeed = 0.2f;

    public FixedJoystick joystick;  
    Camera m_Camera;

    Quaternion camRot;
    Quaternion playerRot;

    void Start()
    {
        m_Camera = Camera.main;
        camRot = m_Camera.transform.localRotation;
        playerRot = transform.localRotation;
    }

    void Update()
    {
        HandleMove();
        HandleCameraLook();
    }

    void HandleMove()
    {
        Vector2 mvVector = new Vector2(joystick.Horizontal, joystick.Vertical);

        Vector3 dir =
            transform.forward * mvVector.y +
            transform.right * mvVector.x;

        transform.position += dir * mvSpeed * Time.deltaTime;
    }

    void HandleCameraLook()
    {
        if (Input.touchCount <= 0)
            return;

        Touch t = Input.GetTouch(0);

        if (t.phase == TouchPhase.Moved)
        {
            Vector2 delta = t.deltaPosition * rotSpeed * Time.deltaTime;

            playerRot *= Quaternion.Euler(0, delta.x, 0);
            transform.localRotation = playerRot;

            camRot *= Quaternion.Euler(-delta.y, 0, 0);
            m_Camera.transform.localRotation = camRot;
        }
    }
}
	