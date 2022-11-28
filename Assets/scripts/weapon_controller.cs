using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon_controller : MonoBehaviour
{


    public weapon my_weapon;
    weapon last_weapon;

    public Transform tip;


    // Start is called before the first frame update
    void Start()
    {
        last_weapon = my_weapon;
        my_weapon._in_it_setting();
    }

    // Update is called once per frame
    void Update()
    {
        if(last_weapon != my_weapon)
        {
            last_weapon = my_weapon;
            my_weapon._in_it_setting();
        }

        my_weapon._using(tip);

        if(my_weapon.data.max_bullet == 0)
        {
            my_weapon = GetComponent<Defeat_gun1>();
        }
    }

    public void change_weapon_rifle()
    {
        my_weapon = GetComponent<Rifle_gun>();   
    }
    public void change_weapon_defalt()
    {
        my_weapon = GetComponent<Defeat_gun1>();
    }
}
