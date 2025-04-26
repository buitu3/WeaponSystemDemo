using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

namespace WeaponSystem
{
    public enum WeaponState
    {
        Idle,
        Attacking,
        Reloading
    }

    public enum AttackType
    {
        SingleShot,
        Continuos
    }
    
    public class Weapon : MonoBehaviour, IPointerDownHandler
    {
        public string Name;
        
        [SerializeField] protected AttackType AttackType;
        // Time between attacks in seconds
        [SerializeField] protected float AttackInterval;

        protected WeaponState CurrentState;

        private void Start()
        {
            Initialize();
        }

        public virtual void Initialize()
        {
            
        }
        
        public virtual void Attack()
        {
            CurrentState = WeaponState.Attacking;
            if(AttackType == AttackType.SingleShot) StartCoroutine(WeaponCoolDown());
        }
        
        public void OnPointerDown(PointerEventData eventData)
        {
            Player.Instance.ChangeWeapon(this);
        }
        
        public virtual bool CanAttack()
        {
            return CurrentState == WeaponState.Idle;
        }

        private IEnumerator WeaponCoolDown()
        {
            yield return new WaitForSeconds(AttackInterval);
            CurrentState = WeaponState.Idle;
        }
    }
}

