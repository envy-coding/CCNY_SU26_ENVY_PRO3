using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAYER : MonoBehaviour
{
    public Rigidbody rB;
    
    //movement
    public float horizontalInput;
    public float speed;

    //yoyo
    public int yosLeft;
    public int LevelNumber;


    public static void QuerySceneInfo(Scene scene)
    {
        Debug.Log(scene.name);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       speed = 10;
       
       
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
        Turn();
    }

    private void FixedUpdate()
    {
        rB.linearVelocity = new Vector2(horizontalInput * speed, rB.linearVelocity.x);
    }

    public void Yo()
    {
        if(yosLeft > 0)
        {
            yosLeft--;
        }
    }

    public void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //shoot yoyo
        }
    }

    public void Turn()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //turn left
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            //turn right
        }
    }

    public void HowManyYos(Scene scene)
    {
        if(scene.name == "LEVEL 1")
        {
            yosLeft = 1;
        }

        if(scene.name == "LEVEL 2")
        {
            yosLeft = 2;
        }

        if(scene.name == "LEVEL 3")
        {
            yosLeft = 3;
        }
    }
}
