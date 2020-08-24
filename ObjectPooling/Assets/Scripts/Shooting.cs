using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    private ObjectPooler.ObjectInfo.ObjectType bulletType;
    [SerializeField]
    private Vector3 spawnPosition;

    private void Update()
    {
        var bullet = ObjectPooler.Instance.GetObject(bulletType);
        bullet.GetComponent<Bullet>().OnCreate(spawnPosition, transform.rotation);
    }
}
