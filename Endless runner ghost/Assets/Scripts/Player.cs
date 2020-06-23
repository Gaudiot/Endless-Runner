using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour{
    private Vector2 targetPos;
    public float Yincrement;

    public float speed;
    public float maxHeight;
    public float minHeight;

    public GameObject effect;
    public Animator camAnim;
    public Text healthText;

    public int health = 3;

    public GameObject gameover;

    // Update is called once per frame
    void Update(){
        healthText.text = health.ToString();

        if(health <= 0) {
            gameover.SetActive(true);
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight) {
            camAnim.SetTrigger("shake");

            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);

        }else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight) {
            camAnim.SetTrigger("shake");
            
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }  
    }
}
