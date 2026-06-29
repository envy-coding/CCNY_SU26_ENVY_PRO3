using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAYER : MonoBehaviour
{
    public Rigidbody playerRB;
    public Transform playerTransform;
    public GameObject yoyo;

   
    float y;
    
    void FixedUpdate()
    {

        Vector3 movement = new Vector3(0, y, 0).normalized;

        if(movement == Vector3.zero)
        {
            return;
        }

        Quaternion targetRotation = Quaternion.LookRotation(movement);

        playerRB.MoveRotation(targetRotation);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       playerTransform = GetComponent<Transform>();
       playerRB = GetComponent<Rigidbody>();
    }

}
