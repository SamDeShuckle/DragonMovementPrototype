using UnityEngine;

public class Delete_Yourself : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with: " + collision.collider.gameObject.name);
        Debug.Log("Collision Tag: " + collision.collider.gameObject.tag);
        if (collision.collider.gameObject.CompareTag("fire"))
        {
            Destroy(gameObject);
        }
    }
}

