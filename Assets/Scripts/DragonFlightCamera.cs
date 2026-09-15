using UnityEngine;

public class DragonFlightCamera : MonoBehaviour
{
    Rigidbody rb;
    public GameObject yaw;
    public GameObject pitch;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Mouse X");
        float vertical = Input.GetAxis("Mouse Y");

        // Rotate the camera
        yaw.transform.Rotate(Vector3.up * horizontal, Space.Self);
        pitch.transform.Rotate(Vector3.right * -vertical, Space.Self);

        //Vector3 localForward = yaw.transform.InverseTransformDirection(pitch.transform.forward);
        ////Debug.Log("Local forward: " + localForward);
        //yaw.transform.Translate(localForward * Time.deltaTime * 10f);
        ////transform.position = Vector3.zero;
        
    }
}
