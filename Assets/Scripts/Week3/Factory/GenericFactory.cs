using UnityEngine;

public abstract class GenericFactory : MonoBehaviour
{
    public abstract GameObject SpawnGameObject(GameObject prefab);
}
