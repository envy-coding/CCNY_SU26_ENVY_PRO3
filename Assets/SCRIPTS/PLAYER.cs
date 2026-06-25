using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAYER : MonoBehaviour
{
    public Rigidbody playerRB;
    public Transform playerTransform;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Turn(); 
    }

    public void Turn()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerTransform.rotation = Quaternion.Euler(0, 180, 0);
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerTransform.rotation = Quaternion.Euler(0, -180, 0);
        }
    }

}
