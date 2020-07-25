using System.Threading;
using UnityEngine;

public class cube1behavior : MonoBehaviour
{
    public Rigidbody rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
