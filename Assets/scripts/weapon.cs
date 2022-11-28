using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����ü = new �����ھ��� ���� ����. ������ �ٷ� �Ҵ�
//���� * ������ ������ ���� �����÷ο찡 �߻��� �� ����.
public struct Data
{
    public float deley_time;
    public int max_bullet;
    public string info;
    public GameObject bullet;
}

//�߻� Ŭ��..  player�� ���������
public abstract class weapon : MonoBehaviour
{
    public Data data;


    bool shoot_able = true;
    float rest_time = 0f;


    // abstract �� ���� {}���°� ����.
    public abstract void _in_it_setting();

    //virtual�� �ٲٸ� ������ �Ҽ��ְԵȴ�. �������� �� �Լ��� ���⼭ ���� ����~
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
