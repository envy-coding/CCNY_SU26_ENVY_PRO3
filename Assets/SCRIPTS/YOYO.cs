using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YOYO : MonoBehaviour
{
    public Transform yoyoTransform;
    public Rigidbody rB;

    public GameObject yoyo;

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
        yoyoTransform = GetComponent<Transform>();yoyoTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Yo();
        }

       
    }

    public void OnTriggerEnter(Collider other)
    {   
        if(other.gameObject.tag == "Target")
            {
                Destroy(other.gameObject);
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

        if(scene.name == "TUTORIAL")
        {
            yosLeft = 10;
        }
    }

    public void Yo()
    {
        if(yosLeft > 0)
        {
            Shoot();
            yosLeft--;
        }
    }

    public void Shoot()
    {
        rB.AddForce(Vector3.right * 500);
    }


}
