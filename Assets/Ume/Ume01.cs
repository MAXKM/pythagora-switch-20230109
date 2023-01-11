using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

public class Ume01 : MonoBehaviour
{
    GameObject Down;
    GameObject BOX;
    GameObject Sphere;
    bool tmp;
    void Start()
    {
        Down = GameObject.Find("stopper");
        BOX = GameObject.Find("Box");
        Sphere = GameObject.Find("Sphere");
        tmp = false;
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = BOX.transform;
        Vector3 pos = myTransform.position;
        if (tmp == true && pos.y < 8.0f)
        {
            pos.y += 0.01f;
        }
        myTransform.position = pos;
        if (pos.y > 8.0f)
        {
            Destroy(Down);
            Debug.Log("Hit");
        }
    }

    void OnCollisionEnter(Collision Sphere)
    {
        tmp = true;
    }
}
