using UnityEngine;

public class collision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("I have been hit:(");
        }
        
    }
    public void OllisionEnter(Collision collision)
    {
        
    }
}
