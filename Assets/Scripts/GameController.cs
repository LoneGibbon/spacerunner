using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public float camSpeed;

    public float bgSpeed;

    public Renderer bgRenderer;

    public Text scoreText;
    public GameObject gameOverPanel;
    private float score;

    private void Awake()
    {
        gameOverPanel.SetActive(false);
        scoreText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            transform.position += new Vector3(camSpeed * Time.deltaTime, 0, 0);
            bgRenderer.material.mainTextureOffset += new Vector2(bgSpeed * Time.deltaTime, 0);
            score += 1 * Time.deltaTime;
            Debug.Log(score);
            scoreText.text = ((int)score).ToString();
        }
        else
        {
            gameOverPanel.SetActive(true);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
