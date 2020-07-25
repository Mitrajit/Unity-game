using UnityEngine;

public class cube1behavior : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        Debug.Log("Program started");
    }
    void FixedUpdate()
    {
            rb.AddForce(0, 0, 700 * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(800 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-800 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, 200 * Time.deltaTime);
        }
    }
}
