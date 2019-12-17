using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
                  
    }

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * (Time.deltaTime/2));

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
    }
}
