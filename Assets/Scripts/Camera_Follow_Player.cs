using UnityEngine;
using UnityEngine.InputSystem;
public class Camera_Follow_Player : MonoBehaviour
{
    public GameObject player;
    private Vector3 splitVector;
    public float cameraVelocity = 1.5f;
    private float timer = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 lookInput = InputSystem.actions["Look"].ReadValue<Vector2>();

        transform.position = player.transform.position;
        if (lookInput.magnitude < 0.1f)
        {
            transform.Rotate(-Vector3.Cross(player.transform.forward, transform.forward), Space.World);
            transform.Rotate(-Vector3.Cross(player.transform.up, transform.up), Space.World);
        }
        else
        {
            transform.Rotate(Vector3.up * lookInput.x * cameraVelocity, Space.World);
            transform.Rotate(Vector3.right * -lookInput.y * cameraVelocity, Space.Self);
        }
    }
}
