using UnityEngine;

namespace WeaponSystem
{
    public class LaserGun : RayWeapon
    {
        public override void Attack()
        {
            if(!CanAttack()) return;
            base.Attack();
            Debug.Log("Laser Gun Fire");
        }
    }

}
