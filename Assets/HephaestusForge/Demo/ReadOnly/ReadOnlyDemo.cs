using UnityEngine;

namespace HephaestusForge.ReadOnly
{
    /// <summary>
    /// This is just a demo class and can be deleted
    /// </summary>
    public class ReadOnlyDemo : MonoBehaviour
    {
#pragma warning disable 0649

        [SerializeField]
        private int _test1;

        [SerializeField, ReadOnly]
        private int _test2 = 445;

#pragma warning restore 0649
    }
}