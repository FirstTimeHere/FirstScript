using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;

    private static int s_negativeOne = -1;

    private void CheckSpeedNegative()
    {
        if (_moveSpeed < 0)
        {
            _moveSpeed = _moveSpeed * s_negativeOne;
        }
    }

    private void MoveThisObject()
    {
        float distance = _moveSpeed * Time.deltaTime;

        transform.Translate(distance * Vector3.forward);
    }

    private void Update()
    {
        CheckSpeedNegative();
        MoveThisObject();
    }
}
