using UnityEngine;
using UnityEngine.EventSystems;

namespace WeaponSystem
{
    public class GrenadeLauncher : ProjectileWeapon
    {
        public override void Attack()
        {
            if(!CanAttack()) return;
            base.Attack();
            Debug.Log("Grenade Launcher Fire");
        }
        
    }
}