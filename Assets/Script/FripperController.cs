using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{

    private HingeJoint myHingeJoint;
    private float defaultAngle = 20;
    private float flickAngle = -20;




    // Use this for initialization
    void Start()
    {

        this.myHingeJoint = GetComponent<HingeJoint>();

        SetAngle(this.defaultAngle);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }




        //MultiTap
        if (Input.touchCount > 0)
        {
            Touch[] myTouches = Input.touches;

            for (int i = 0; i < myTouches.Length; i++)
            {
                Vector3 ScreenPos = myTouches[i].position;
                ScreenPos.z = 1.0f;
                Vector3 WorldPos = Camera.main.ScreenToWorldPoint(ScreenPos);


                //右タップ
                if (WorldPos.x >= 0)
                {
                    if (myTouches[i].phase == TouchPhase.Began && tag == "RightFripperTag")
                    {
                        SetAngle(this.flickAngle);
                    }

                    if (myTouches[i].phase == TouchPhase.Ended && tag == "RightFripperTag")
                    {
                        SetAngle(this.defaultAngle);
                    }
                }
                else
                {
                    if (myTouches[i].phase == TouchPhase.Began && tag == "LeftFripperTag")
                    {
                        SetAngle(this.flickAngle);
                    }

                    if (myTouches[i].phase == TouchPhase.Ended && tag == "LeftFripperTag")
                    {
                        SetAngle(this.defaultAngle);
                    }
                }

            }

        }


    }

    public void SetAngle(float angle)
    {
        JointSpring JointSpr = this.myHingeJoint.spring;
        JointSpr.targetPosition = angle;
        this.myHingeJoint.spring = JointSpr;
    }

}
