using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medal : MonoBehaviour
{
    enum MedalType
    {
        MEDAL_BRONZE,
        MEDAL_SILVER,
        MEDAL_GOLD,
    };

    public Sprite[] m_medalImage;

    public int m_score;


    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        m_score = GameObject.Find("Canvas").GetComponent<ScoreController>().GetScore();

        if ((m_score >= 10) && (m_score <= 30))
        {
            GetComponent<SpriteRenderer>().sprite = m_medalImage[(int)MedalType.MEDAL_BRONZE];
        }
        else if ((m_score >= 31) && (m_score <= 70))
        {
            GetComponent<SpriteRenderer>().sprite = m_medalImage[(int)MedalType.MEDAL_SILVER];
        }
        else if (m_score >= 71)
        {
            GetComponent<SpriteRenderer>().sprite = m_medalImage[(int)MedalType.MEDAL_GOLD];
        }

    }
}
