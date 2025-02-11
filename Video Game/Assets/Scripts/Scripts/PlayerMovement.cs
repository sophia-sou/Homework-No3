using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; 
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public GameObject LevelEnd;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))                           
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);    
        }                                                                                  

        if (Input.GetKey("a"))                            
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);      
        }

        if (rb.position.y < -1f)
        {
            endGame();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == LevelEnd)
        {
            endGame();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Obstacle"))
        {
            endGame();
        }
    }

    private void endGame()
    {
        forwardForce = 0;
        SceneManager.LoadScene("Score");
    }
}
