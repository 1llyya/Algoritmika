using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{   //Здоровье
    int health = 5;

    //Уровень
    int level = 1;

    //Скорость
    float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print(health);
    }
  

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
