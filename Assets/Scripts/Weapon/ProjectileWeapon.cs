using UnityEngine;

namespace WeaponSystem
{
    public class ProjectileWeapon : Weapon
    {
        public int MagazineSize;
        [HideInInspector]
        public int BulletInMagazine;

        public override void Initialize()
        {
            BulletInMagazine = MagazineSize;
        }
        
        public override void Attack()
        {
            if(BulletInMagazine <= 0) return;
            BulletInMagazine--;
            
            base.Attack();
        }
        
        public void Reload()
        {
            BulletInMagazine = MagazineSize;
        }

        public override bool CanAttack()
        {
            if (!base.CanAttack()) return false;
            if(BulletInMagazine <= 0) return false;
            return true;
        }
    }

}
