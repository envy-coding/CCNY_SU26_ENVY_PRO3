using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAYER : MonoBehaviour
{
    public Rigidbody playerRB;
    public Transform playerTransform;

    //yoyo
    public int yosLeft;
    public int LevelNumber;

    public Transform yoyoTransform;
    public Rigidbody yoyoRB;

    //wave variables
    private int amplitude = 1;
    private int frequency = 1;

    public GameObject yoyo;


    public static void QuerySceneInfo(Scene scene)
    {
        Debug.Log(scene.name);
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
       yoyoTransform = GetComponent<Transform>();
       
       

       playerTransform = GetComponent<Transform>();
       
    }

    // Update is called once per frame
    void Update()
    {
        Turn(); 
        Yo();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();    
        }
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
        float x = Mathf.Sin(Time.time * frequency) * amplitude;
        float y = this.transform.position.y;
        float z = this.transform.position.z;

        this.yoyoTransform.position = new Vector3(x, y, z);
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
