using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    bool m_pushedFlag;
    bool m_pushingFlag;
    float m_pushDifference = 0.03f;

	// Use this for initialization
	void Start ()
    {
        m_pushedFlag = false;
        m_pushingFlag = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        // マウスの座標をを取得
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Collider2D collider2d = Physics2D.OverlapPoint(mousePos);

        // ボタンの中にある
        if (collider2d)
        {
            if (collider2d.transform.gameObject == gameObject)
            {
                // マウスがクリックされる
                if (Input.GetMouseButtonDown(0))
                {
                    if (collider2d.transform.gameObject == gameObject)
                    {
                        transform.position += new Vector3(0.0f, -m_pushDifference, 0.0f);
                        m_pushingFlag = true;
                    }
                }
            }

            // 押されている and マウスが離された
            if (m_pushingFlag && Input.GetMouseButtonUp(0))
            {
                transform.position += new Vector3(0.0f, m_pushDifference, 0.0f);

                if (m_pushedFlag)
                {
                    // OFF
                    m_pushedFlag = false;
                }
                else
                {
                    // ON
                    m_pushedFlag = true;
                }
            }
        }

        // ボタンの外 and ボタンが押されている
        if(!collider2d&&m_pushingFlag)
        {
            transform.position += new Vector3(0.0f, m_pushDifference, 0.0f);
            m_pushingFlag = false;
        }
    }

    public bool GetPushFlag()
    {
        return m_pushedFlag;
    }
}
