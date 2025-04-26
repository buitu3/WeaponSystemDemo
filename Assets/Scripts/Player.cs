using TMPro;
using UnityEngine;

namespace WeaponSystem
{
    public class Player : MonoBehaviour
    {
        public static Player Instance;

        [SerializeField] private TextMeshProUGUI WeaponText;
        [SerializeField] private TextMeshProUGUI AmmoText;
        
        [HideInInspector]
        public Weapon CurrentWeapon;
        
        private void Awake()
        {
            Instance = this;
        }

        public void Attack()
        {
            if(CurrentWeapon != null) CurrentWeapon.Attack();
            UpdateAmmoText();
        }
        
        public void ChangeWeapon(Weapon weapon)
        {
            CurrentWeapon = weapon;
            UpdateWeaponText();
            UpdateAmmoText();
            
            Debug.Log("Change weapon: " + weapon.Name);
        }
        
        public void RealoadWeapon()
        {
            if (CurrentWeapon == null) return;
            if (CurrentWeapon is ProjectileWeapon)
            {
                ProjectileWeapon projectileWeapon = (ProjectileWeapon) CurrentWeapon;
                projectileWeapon.Reload();
                UpdateAmmoText();
            }
            else if (CurrentWeapon is RayWeapon)
            {
                RayWeapon rayWeapon = (RayWeapon) CurrentWeapon;
                rayWeapon.Recharge();
                UpdateAmmoText();
            }
        }
        
        public void UpdateWeaponText()
        {
            WeaponText.text = CurrentWeapon.Name;
        }
        
        public void UpdateAmmoText()
        {
            if (CurrentWeapon == null) return;
            if (CurrentWeapon is ProjectileWeapon)
            {
                ProjectileWeapon projectileWeapon = (ProjectileWeapon) CurrentWeapon;
                AmmoText.text = projectileWeapon.BulletInMagazine + "/" + projectileWeapon.MagazineSize;
            }
            else if (CurrentWeapon is RayWeapon)
            {
                RayWeapon rayWeapon = (RayWeapon) CurrentWeapon;
                AmmoText.text = rayWeapon.EnergyLeft.ToString();
            }
            else AmmoText.text = "-/-";
        }
    }
}
