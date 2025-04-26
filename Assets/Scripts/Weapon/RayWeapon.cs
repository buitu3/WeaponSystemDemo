using System.Collections;
using UnityEngine;

namespace WeaponSystem
{
    public class RayWeapon : Weapon
    {
        [SerializeField] protected int EnergyDepleteRate;
        [HideInInspector] public int EnergyLeft;
        
        private int StartEnergy = 200;
        
        public override void Initialize()
        {
            EnergyLeft = StartEnergy;
        }
        
        public override void Attack()
        {
            if(!CanAttack()) return;
            EnergyLeft -= EnergyDepleteRate;
            base.Attack();
        }

        public override bool CanAttack()
        {
            if(EnergyLeft <= 0) return false;
            return true;
        }

        public void Recharge()
        {
            EnergyLeft = StartEnergy;
        }
    }

}
