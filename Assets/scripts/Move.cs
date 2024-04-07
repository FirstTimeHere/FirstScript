using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] [Range(0,1000)] private float _moveSpeed;

    private void MoveThisObject()
    {
        float distance = _moveSpeed * Time.deltaTime;

        transform.Translate(distance * Vector3.forward);
    }

    private void Update()
    {
        MoveThisObject();
    }
}
