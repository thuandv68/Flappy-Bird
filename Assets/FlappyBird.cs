using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBird : MonoBehaviour
{

     public Rigidbody2D rg;
    public float speed;
    public GameObject gameOverObj;

    void Start() {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) {
            rg.AddForce(Vector2.up * this.speed);
        }
        if (Input.GetKeyDown(KeyCode.Return)) 
        {
            SceneManager.LoadScene(0);
        }
    }

    public void ResetGame() {
        SceneManager.LoadScene(0);
    }

    void GameOver() {
        Time.timeScale = 0;
        gameOverObj.SetActive(true);
    }

    void OnCollisionEnter2D(Collision2D collision) {
        GameOver();
    }
}
