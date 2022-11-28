using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//구조체 = new 연산자없이 실행 가능. 스택이 바로 할당
//주의 * 변수가 많으면 스택 오버플로우가 발생할 수 있음.
public struct Data
{
    public float deley_time;
    public int max_bullet;
    public string info;
    public GameObject bullet;
}

//추상 클라스..  player에 상속해주자
public abstract class weapon : MonoBehaviour
{
    public Data data;


    bool shoot_able = true;
    float rest_time = 0f;


    // abstract 를 쓰면 {}형태가 없다.
    public abstract void _in_it_setting();

    //virtual로 바꾸면 구현을 할수있게된다. 공통으로 쓸 함수는 여기서 쓰면 개꿀~
    public virtual void _using(Transform tip)
    {
        if(Input.GetKey(KeyCode.Space) && shoot_able)
        {
            var bull = Instantiate(data.bullet);
            bull.transform.position = tip.position;
            Rigidbody2D rigid_bullets = bull.GetComponent<Rigidbody2D>();
            rigid_bullets.velocity = transform.right * 10f;

            shoot_able = false;
            data.max_bullet--;
        }

        if (shoot_able == false)
        {
            rest_time += Time.deltaTime;
            if(rest_time >= data.deley_time)
            {
                shoot_able = true;
                rest_time = 0f;
            }
        }
    }
}
