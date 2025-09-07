using System.Diagnostics;
using TMPro;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float moveSpeed;
    public TMP_Text messageText; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float Xmove = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float Zmove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.position += new Vector3(Xmove, 0, Zmove);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("The move speed is " + moveSpeed);
            moveSpeed += 10;
            messageText.text = "The move speed is " + moveSpeed.ToString();

        }
       
        
    }

}
