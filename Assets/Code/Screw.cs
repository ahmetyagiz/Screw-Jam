using UnityEngine;

public class Screw : MonoBehaviour
{
    [SerializeField] private Joint2D joint;  // Çiviyle iliþkili olan FixedJoint2D'yi buraya baðla

    public void DestroyNail()
    {
        // Çivi yok olduðunda baðlantýyý kaldýr
        if (joint != null)
        {
            Destroy(joint);
        }
        // Daha sonra çiviyi yok et
        Destroy(gameObject);
    }
}