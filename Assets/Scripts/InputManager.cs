using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace WeaponSystem
{
    public class InputManager : MonoBehaviour
    {
        private void Update()
        {
            if(Input.GetMouseButtonDown(0)) Player.Instance.Attack();
            if(Input.GetKeyDown(KeyCode.R)) Player.Instance.RealoadWeapon();
        }
    }

}
