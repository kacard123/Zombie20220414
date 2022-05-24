
using UnityEngine;

public interface IDamageable 
{
    void OnDamage(float damage, Vector3 hitPoint, Vector3 hitNormal);   // 데미지, 충돌한 위치, 표면의 방향
}