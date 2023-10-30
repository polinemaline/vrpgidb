using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere1 : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject sphere;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ActiveObject()
    {
        if (sphere.activeSelf != true)
        {
            sphere.SetActive(true);
        }
        else
        {
            sphere.SetActive(false);
        }
    }
}