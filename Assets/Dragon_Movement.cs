using UnityEngine;

public class Dragon_Movement : MonoBehaviour
{
    public GameObject rotationMatch;
    public GameObject rotatorY;
    public GameObject fire;
    public Rigidbody rb;
    public float maxspeed = 10.0f;
    public float moveForce = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.linearVelocity = Vector3.zero;
        
        //rb.linearVelocity = transform.forward * maxspeed;
        if (rb.linearVelocity.magnitude < maxspeed)
            rb.AddForce(transform.forward * moveForce, ForceMode.Acceleration);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fire.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            fire.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = rotationMatch.transform.rotation;
    }
}
