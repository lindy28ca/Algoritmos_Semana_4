using UnityEngine;
public interface ITransforms
{
    string Nombre { get; set; }
    Vector3 Posicion { get; set; }
    void MoverA(Vector3 nuevaPosicion);
}
public class Entity : MonoBehaviour, ITransforms
{
    public string Nombre { get; set; }
    public Vector3 Posicion { get; set; }

    public Entity(string nombre, Vector3 posicion)
    {
        Nombre = nombre;
        Posicion = posicion;
    }

    public void MoverA(Vector3 nuevaPosicion)
    {
        Posicion = nuevaPosicion;
    }
}
