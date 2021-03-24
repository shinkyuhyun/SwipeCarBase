using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject Car;
    GameObject flag;
    GameObject distance;
   
    void Start()
    {
        this.Car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    
    void Update()
    {
        float length = this.flag.transform.position.x - this.Car.transform.position.x;
        this.distance.GetComponent<Text>().text = "목표지점까지" + length.ToString("F2") + "m";
    }
}
