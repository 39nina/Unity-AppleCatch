using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour
{
    GameObject gameDirector;
    GameObject scoreText;

    public void OnClickStartButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    void Start()
    {
        this.scoreText = GameObject.Find("Score");
        this.scoreText.GetComponent<Text>().text = "Your Score：" + GameDirector.point.ToString() + " point !!";
    }
}
