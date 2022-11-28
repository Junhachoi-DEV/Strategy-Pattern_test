using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//추상 참조 누르면 자동으로 써짐
public class Defeat_gun1 : weapon
{
    public override void _in_it_setting()
    {
        //throw new System.NotImplementedException();
        data.deley_time = 1f;
        data.info = "현재무기:기본권총";
        data.max_bullet = 10;

        //이부분은 최적화 방법에 안좋다고 함. 
        //리소스 는 파일들이 메모리에 올려져있는것이라 반복적으로 호출하면 안됨
        // 즉 총을이리 저리 바꾸면서 쏘면 안된다는것
        // 짧은 시간에 반복해서 호출하는게 아니라면 Resource 폴더 써도 상관없음
        
        // 예)
        //GameObject obj = Resources.Load<GameObject>("Assets/Resources/이하경로");
        
        data.bullet = Resources.Load<GameObject>("bullet");
        

    }

    public override void _using(Transform tip)
    {
        //throw new System.NotImplementedException();

        base._using(tip);
    }
}
