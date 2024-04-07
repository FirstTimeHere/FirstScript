using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] [Range(0, 1000)] private float _speed;
    [SerializeField] [Range(1, 1000)] private float _maxScale;

    private bool _isBigger;

    private Vector3 _scale;

    private void TryScale()
    {
        if (_scale.x <= _maxScale && _isBigger == false)
        {
            _scale += new Vector3(_speed * Time.deltaTime, _speed * Time.deltaTime, _speed * Time.deltaTime);
        }
        else
        {
            _isBigger = true;
            _scale -= new Vector3(_speed * Time.deltaTime, _speed * Time.deltaTime, _speed * Time.deltaTime);
        }

        transform.localScale = _scale;

        if (_scale.x >= _maxScale || _scale.x <= 0)
        {
            _isBigger = !_isBigger;
        }
    }

    private void Update()
    {
        TryScale();
    }
}
