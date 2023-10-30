using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sphere2 : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject sphere;
    public float COUNTER;
    public Text text;


    // Start is called before the first frame update
    void Start()
    {
        COUNTER = 3;
        text.text = "counter: " + COUNTER;
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
    private void OnCollisionEnter(Collision collision)
    {
        COUNTER--;
        text.text = "counter: " + COUNTER;
        this.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}
/*public class counter : MonoBehaviour
{
    public float COUNTER;
    public Text text;


    // Start is called before the first frame update
    void Start()
    {
        COUNTER = 3;
        text.text = "counter: " + COUNTER;
    }

    // Update is called once per frame

    private void OnCollisionEnter(Collision collision)
    {
        COUNTER--;
        text.text = "counter: " + COUNTER;
    }
}*/



