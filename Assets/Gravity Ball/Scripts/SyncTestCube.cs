using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncTestCube : MonoBehaviour {

    public float m_ScrollSpeed = 30f;

    public float m_YawSpeed = 30f;

    private Rigidbody m_Rigidbody;

    private Material m_ColorMaterial;

    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_ColorMaterial = GetComponent<Renderer>().material;
        m_ColorMaterial.color = Color.white;

    }



    // Update is called once per frame
    void Update () {
       
		if(GravityBall.Instance.GetButton())
        {
            m_ColorMaterial.color = Color.red;
        }
        else
        {
            m_ColorMaterial.color = Color.white;
        }

        float scroll = GravityBall.Instance.GetInputSwipe("Scroll");
        float yaw = GravityBall.Instance.GetInputSwipe("Stroke");

        transform.Rotate(scroll * m_ScrollSpeed, yaw * m_YawSpeed, 0f,Space.World);
    }
   
}
