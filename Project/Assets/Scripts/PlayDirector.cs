using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayDirector : MonoBehaviour
{
    bool m_tutorialFlag;
    bool m_resultFlag;
    private GameObject m_result;

	// Use this for initialization
	void Start ()
    {
        m_tutorialFlag = true;
        m_resultFlag = false;
        m_result = GameObject.Find("ResultPrefab");

        if(!m_resultFlag)
        {
            m_result.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(m_resultFlag)
        {
            if (GameObject.Find("ResultPrefab/OK").GetComponent<ButtonController>().GetPushFlag())
            {
                SceneManager.LoadScene("Scenes/TitleScene");
            }
        }

    }

    public bool GetTutorialFlag()
    {
        return m_tutorialFlag;
    }

    public void FinishTutorial()
    {
        m_tutorialFlag = false;
    }

    public bool GetResultFlag()
    {
        return m_resultFlag;
    }

    public void FinishPlay()
    {
        if(!m_resultFlag)
        {
            GetComponent<AudioSource>().Play();
        }
        m_resultFlag = true;
        m_result.SetActive(true);       
    }
}
