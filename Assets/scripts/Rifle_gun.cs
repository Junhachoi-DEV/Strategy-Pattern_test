using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle_gun : weapon
{
    public override void _in_it_setting()
    {
        data.deley_time = 0.2f;
        data.info = "���繫��:�����";
        data.max_bullet = 30;
        data.bullet = Resources.Load<GameObject>("r_bullet");
    }
    public override void _using(Transform tip)
    {
        //throw new System.NotImplementedException();

        base._using(tip);
        // ���⿡ �� �ɼ� ���� ��
    }
}
