using UnityEngine;

public class Bullet : MonoBehaviour, IPooledObject
{
    public ObjectPooler.ObjectInfo.ObjectType Type => type;

    [SerializeField]
    private ObjectPooler.ObjectInfo.ObjectType type;

    private float lifeTime = 3;
    private float currentLifeTime;
    private float speed = 10;

    public void OnCreate(Vector3 position, Quaternion rotation)
    {
        transform.position = position;
        transform.rotation = rotation;
        currentLifeTime = lifeTime;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if ((currentLifeTime -= Time.deltaTime) < 0)
            ObjectPooler.Instance.DestroyObject(gameObject);
    }
}
