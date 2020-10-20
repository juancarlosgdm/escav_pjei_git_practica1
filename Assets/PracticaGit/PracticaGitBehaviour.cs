using UnityEngine;

public class PracticaGitBehaviour : MonoBehaviour {
    [SerializeField]
    [Tooltip("Introducir nombre del autor")]
    private string nombreAutor;
    
    private void Start() {
        Debug.Log("Autor de la practica: ");
        Debug.Log(nombreAutor);
    }
}