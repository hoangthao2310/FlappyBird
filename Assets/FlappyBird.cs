using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBird : MonoBehaviour
{
    Rigidbody2D rg;
    public float speed;
    public GameObject gameOverObj;
    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 1;
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) //trai: 0, phai: 2
        {
            rg.velocity = Vector3.zero;
            rg.AddForce(Vector2.up * speed);

        }
        
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(0);
    }
    void GameOver()
    {
        gameOverObj.SetActive(true);
        Time.timeScale = 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver();
    }
}
