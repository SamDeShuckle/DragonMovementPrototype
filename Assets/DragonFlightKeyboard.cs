using UnityEngine;

public class DragonFlightKeyboard : MonoBehaviour
{
    Rigidbody rb;
    public GameObject yaw;
    public GameObject pitch;
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Rotate the camera
        //Debug.Log(vertical);
        pitch.transform.Rotate(Vector3.forward * -horizontal*2.0f, Space.Self);
        pitch.transform.Rotate(Vector3.right * -vertical*1.0f, Space.Self);

        if (player.transform.right.y > 0.1f || player.transform.right.y < -0.1f)
        {
            Debug.Log(player.transform.right.y);
            //Debug.Log("Rotate");
            //Vector3 localForward = yaw.transform.InverseTransformDirection(pitch.transform.forward);
            yaw.transform.Rotate(Vector3.up * -player.transform.right.y*0.3f, Space.Self);
            //Debug.Log(Vector3.up * horizontal * player.transform.right.y);
        }
        //Vector3 localForward = yaw.transform.InverseTransformDirection(pitch.transform.forward);
        ////Debug.Log("Local forward: " + localForward);
        //yaw.transform.Translate(localForward * Time.deltaTime * 10f);
        ////transform.position = Vector3.zero;

    }
}
