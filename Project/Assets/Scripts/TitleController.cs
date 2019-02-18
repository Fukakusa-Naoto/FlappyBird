using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleController : MonoBehaviour
{
    Vector3 m_startPosition;
    int m_cycleCount;
    public int m_countSpeed = 0;

    // Use this for initialization
    void Start ()
    {
        m_startPosition = transform.position;
        m_cycleCount = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        m_cycleCount += m_countSpeed;

        if(m_cycleCount>=360)
        {
            m_cycleCount = 0;
        }

        Vector3 newPosition = m_startPosition + new Vector3(0.0f, Mathf.Sin(Mathf.Deg2Rad * m_cycleCount) / 3, 0.0f);
        transform.position = newPosition;
	}
}
