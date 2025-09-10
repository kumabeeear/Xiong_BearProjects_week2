using UnityEngine;

public class Move : MonoBehaviour

{
    public float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float Xmove = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float Zmove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.position += new Vector3(Xmove, 0, Zmove);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}