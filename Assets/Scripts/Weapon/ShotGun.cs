using UnityEngine;

namespace WeaponSystem
{
    public class ShotGun : ProjectileWeapon
    {
        public override void Attack()
        {
            if(!CanAttack()) return;
            Debug.Log("ShotGun Fire");
            base.Attack();
        }
    }
}
