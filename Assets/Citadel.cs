using UnityEngine;
using System.Collections.Generic;
using System.Threading;

public class Citadel : MonoBehaviour
{

    public List<GameObject> bases;
    public GameObject barrier;
    int count = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count = 0;
        for(int i = 0; i < bases.Count; i++) {
            if (bases[i] != null)
            {
                Collider collider = bases[i].GetComponent<Collider>();
                count++;
            }
        }
        if(count == 0) {
            barrier.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (barrier.activeSelf == false && count == 0)
        {
            Destroy(gameObject);
        }
    }
}
