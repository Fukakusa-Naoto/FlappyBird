using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;　　//UIを使用可能にする
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public float fadeTime;
    private float currentRemainTime;
    private SpriteRenderer spRenderer;

    // Use this for initialization
    void Start ()
    {
        currentRemainTime = 0;
        spRenderer = GetComponent<SpriteRenderer>();

        var color = spRenderer.color;
        color.a = 0;
        spRenderer.color = color;
    }

    // Update is called once per frame
    void Update ()
    {
        if (GameObject.Find("PlayDirectorPrefab").GetComponent<PlayDirector>().GetResultFlag())
        {
            currentRemainTime += Time.deltaTime;

            // フェードイン
            float alpha = currentRemainTime / fadeTime;
            var color = spRenderer.color;
            color.a = alpha;
            spRenderer.color = color;
        }
    }
}
