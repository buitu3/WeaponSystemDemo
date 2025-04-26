using UnityEngine;

namespace WeaponSystem
{
    public class LaserGun : RayWeapon
    {
        public override void Attack()
        {
            if(!CanAttack()) return;
            Debug.Log("Laser Gun Fire");
            base.Attack();
        }
    }

}
