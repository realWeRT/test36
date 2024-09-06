using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test02 : MonoBehaviour
{
    public int exp = 0;

    public string kkeylog;

    public int level = 1;

    public int donuts = 8;
    public int boxes = 8;

    public GameObject somebody;

    public void getexp(int newexp)
    {
        exp = exp + newexp;
        while (exp > level)
        {
            exp -= level;
            level += 1;

        }
    }

    public int donutssold(int boxes = 0)
    {
        int sum = donuts * boxes;
        return sum;
    }


    // Start is called before the first frame update
    void Start()
    {
        /*getexp(9);
        string message = "level = " + level + "exp " + exp;
        Debug.LogFormat(message);

        boxes = 10;
        Debug.Log("donutssold" + donutssold(6));*/

        Destroy(somebody);

        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0f, 0f, 0f);//ok
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-0.5f, 1f, 0f);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0.5f, 1f, 0f);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0.5f, 2f, 0f);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-0.5f, 2f, 0f);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0f, 3f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space) == true) 
        {
            kkeylog = "";
            kkeylog += "d";
        }
        if (Input.GetKey(KeyCode.Space) == true)

        {
            kkeylog += "p";    
        }
        if (Input.GetKeyUp(KeyCode.Space) == true)

        {
            kkeylog += "u";
        }
        Debug.Log(kkeylog);*/

        print("cricets");
    }
}
