using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScript : MonoBehaviour
{
    public static MonsterScript Instance;
    // public ParticleSystem dot;
    // public GameObject healthBar,firecollider;
    private Animator charAnimator;
    private float timer = 3, timer2 = 1, timer3 = 3;

    private float posX, posY, posZ, spawnPosX, spawnPosY;

    // public GameObject objectToSpawn;
    private float speed = -.04f;
    private float healthMonsterAwal;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        charAnimator = GetComponent<Animator>();
        // dot = GetComponent<ParticleSystem>();
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        // Transform bar = healthBar.transform;
        // bar.localScale = new Vector3(healthMonster / healthMonsterAwal, 1f);

        if (Time.timeScale == 1)
        {
            timer -= Time.deltaTime;
            if (timer >= 0)
            {
                posX = transform.position.x;
                posX += speed;
                transform.position = new Vector3(posX, posY, posZ);
            }
            else
            {
                timer2 -= Time.deltaTime;
                if (timer2 >= 0)
                {
                    transform.position = new Vector3(posX, posY, posZ);
                }
                else
                {
                    transform.position = new Vector3(posX, posY, posZ);

                    timer = 3;
                    timer2 = 1;
                    transform.Rotate(0, 180, 0);
                    speed = speed * -1;
                }
            }
        }
    }
}
