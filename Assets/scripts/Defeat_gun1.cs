using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�߻� ���� ������ �ڵ����� ����
public class Defeat_gun1 : weapon
{
    public override void _in_it_setting()
    {
        //throw new System.NotImplementedException();
        data.deley_time = 1f;
        data.info = "���繫��:�⺻����";
        data.max_bullet = 10;

        //�̺κ��� ����ȭ ����� �����ٰ� ��. 
        //���ҽ� �� ���ϵ��� �޸𸮿� �÷����ִ°��̶� �ݺ������� ȣ���ϸ� �ȵ�
        // �� �����̸� ���� �ٲٸ鼭 ��� �ȵȴٴ°�
        // ª�� �ð��� �ݺ��ؼ� ȣ���ϴ°� �ƴ϶�� Resource ���� �ᵵ �������
        
        // ��)
        //GameObject obj = Resources.Load<GameObject>("Assets/Resources/���ϰ��");
        
        data.bullet = Resources.Load<GameObject>("bullet");
        

    }

    public override void _using(Transform tip)
    {
        //throw new System.NotImplementedException();

        base._using(tip);
    }
}
