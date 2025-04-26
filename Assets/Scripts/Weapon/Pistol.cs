using UnityEngine;

namespace WeaponSystem
{
    public class Pistol : ProjectileWeapon
    {
        public override void Attack()
        {
            if(!CanAttack()) return;
            base.Attack();
            Debug.Log("Pistol Fire");
        }
    }
}
