using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KadaiTokuten : MonoBehaviour
{

    private GameObject TokutenText;
    private int SmallStarPoint = 30;
    private int LargeStarPoint = 50;
    private int SmallCloudPoint = 20;
    private int LargeCloudPoint = 10;
    private int currentPoint;


    // Use this for initialization
    void Start()
    {

        this.TokutenText = GameObject.Find("Tokuten");

    }


    private void OnCollisionEnter(Collision other)
    {
        if (tag == "SmallStarTag")
        {
            currentPoint = int.Parse(this.TokutenText.GetComponent<Text>().text);
            currentPoint += SmallStarPoint;
            this.TokutenText.GetComponent<Text>().text = currentPoint.ToString();
        }
        if (tag == "LargeStarTag")
        {
            currentPoint = int.Parse(this.TokutenText.GetComponent<Text>().text);
            currentPoint += LargeStarPoint;
            this.TokutenText.GetComponent<Text>().text = currentPoint.ToString();
        }
        if (tag == "SmallCloudTag")
        {
            currentPoint = int.Parse(this.TokutenText.GetComponent<Text>().text);
            currentPoint += SmallCloudPoint;
            this.TokutenText.GetComponent<Text>().text = currentPoint.ToString();
        }
        if (tag == "LargeCloudTag")
        {
            currentPoint = int.Parse(this.TokutenText.GetComponent<Text>().text);
            currentPoint += LargeCloudPoint;
            this.TokutenText.GetComponent<Text>().text = currentPoint.ToString();
        }

    }




}
