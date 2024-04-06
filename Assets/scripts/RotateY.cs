using UnityEngine;

public class RotateY : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.rotation *= Quaternion.Euler(0, _speed * Time.deltaTime, 0);
    }
}
