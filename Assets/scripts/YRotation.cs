using UnityEngine;

public class YRotation : MonoBehaviour
{
    [SerializeField] [Range(0, 1000)] private float _speed;

    private void Update()
    {
        transform.rotation *= Quaternion.Euler(0, _speed * Time.deltaTime, 0);
    }
}
