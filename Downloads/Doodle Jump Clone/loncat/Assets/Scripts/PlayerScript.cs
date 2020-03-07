using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerScript : MonoBehaviour
{
    public static PlayerScript Instance;

    private float posX;
    private float posY;
    SpriteRenderer m_SpriteRenderer;
    public bool death = false;
    private float posZ;
    public int countJump = 0;
    public float speed;
    private float dirX;
    // Start is called before the first frame update
    private Rigidbody2D playerRb;
    Animator charAnimator;
    void Start()
    {
        Instance = this;
        playerRb = gameObject.GetComponent<Rigidbody2D>();
         m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        countJump = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
             SceneManager.LoadScene(0);
        }
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;

        // if (countJump < 1)
        // {
        //     playerRb.AddForce(new Vector3(0f, 1f, 0f) * 4, ForceMode2D.Impulse);
        //     countJump = 1;
        // }
        dirX = Input.acceleration.x * 0.1f;
        posX += dirX;
        // transform.position = new Vector2(Mathf.Clamp(transform.position.x, -2.45f, 2.45f), transform.position.y);
        if (Time.timeScale == 1)
        {
            transform.position = new Vector3(Mathf.Clamp(posX, -2.45f, 2.45f), posY, posZ);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // print("fucku");
        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            playerRb.AddForce(Vector3.up * 320f);
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bird")
        {
            transform.position = new Vector3(1.54f,-2.73f,0);  
            GlobalScript.Instance.life -= 1;
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bird")
        {
            // GlobalScript.Instance.health -= 0.5f;
            m_SpriteRenderer.color = Color.red;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bird")
        {
            m_SpriteRenderer.color = Color.white;
        }
    }

    public bool isDeath()
    {
        return death;
    }

}
