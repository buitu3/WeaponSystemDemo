using UnityEngine;

namespace WeaponSystem
{
    public class Pistol : ProjectileWeapon
    {
        public override void Attack()
        {
            if(!CanAttack()) return;
            Debug.Log("Pistol Fire");
            base.Attack();
        }
    }
}
