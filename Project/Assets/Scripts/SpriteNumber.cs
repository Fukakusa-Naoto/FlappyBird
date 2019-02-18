using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteNumber : MonoBehaviour
{
    public GameObject m_numberPrefab;
    public Sprite[] m_numberImage = new Sprite[10];
    public float m_imageSize;
    protected int m_number;
    private List<int> m_numberList = new List<int>();
    private List<GameObject> m_numberObjectList = new List<GameObject>();

    // Use this for initialization
    void Start ()
    {
        m_number = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    protected void Delete()
    {
        for(int i = 0;i < m_numberObjectList.Count;i++)
        {
            Destroy(m_numberObjectList[i]);
        }

        m_numberObjectList.Clear();
        m_numberList.Clear();
    }

    protected void Draw(int number)
    {
        int digit = number;

        //要素数0には１桁目の値が格納
        m_numberList = new List<int>();
        while (digit != 0)
        {
            number = digit % 10;
            digit = digit / 10;
            m_numberList.Add(number);
        }

        for (int i = 0; i < m_numberList.Count; i++)
        {
            //複製
            GameObject numberImage = Instantiate(m_numberPrefab) as GameObject;

            numberImage.transform.position = new Vector3(transform.position.x - i * m_imageSize, transform.position.y, transform.position.z);

            numberImage.GetComponent<SpriteRenderer>().sprite = m_numberImage[m_numberList[i]];

            m_numberObjectList.Add(numberImage);
        }

        if (number != 0)
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
