using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    int m_score;
    public Sprite[] m_numberImage;
    protected int m_number;
    private List<int> m_numberList = new List<int>();

    // Use this for initialization
    void Start()
    {
        m_score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("PlayDirectorPrefab").GetComponent<PlayDirector>().GetResultFlag())
        {
            if (!GameObject.Find("PlayDirectorPrefab").GetComponent<PlayDirector>().GetTutorialFlag())
            {
                GameObject.Find("Score").GetComponent<Image>().enabled = true;

                if (m_score != 0)
                {
                    Delete();

                    Draw(m_score);
                }
            }
            else
            {
                GameObject.Find("Score").GetComponent<Image>().enabled = false;
            }
        }
        else
        {
            GameObject.Find("Score").GetComponent<Image>().enabled = false;
            Delete();
        }
    }

    private void Delete()
    {
        //いままで表示されてたスコアオブジェクト削除
        var objs = GameObject.FindGameObjectsWithTag("Score");
        foreach (var obj in objs)
        {
            if (0 <= obj.name.LastIndexOf("Clone"))
            {
                Destroy(obj);
            }
        }
    }
    private void Draw(int number)
    {
        var digit = number;
        //要素数0には１桁目の値が格納
        m_numberList = new List<int>();
        while (digit != 0)
        {
            number = digit % 10;
            digit = digit / 10;
            m_numberList.Add(number);
        }

        GameObject.Find("Score").GetComponent<Image>().sprite = m_numberImage[m_numberList[0]];

        for (int i = 1; i < m_numberList.Count; i++)
        {
            //複製
            RectTransform scoreImage = (RectTransform)Instantiate(GameObject.Find("Score")).transform;

            scoreImage.SetParent(this.transform, false);

            scoreImage.localPosition = new Vector2(
                scoreImage.localPosition.x - 50 * i,
                scoreImage.localPosition.y);

            scoreImage.GetComponent<Image>().sprite = m_numberImage[m_numberList[i]];
        }
    }

    public void AddScore()
    {
        GetComponent<AudioSource>().Play();
        m_score++;
    }

    public int GetScore()
    {
        return m_score;
    }
}
