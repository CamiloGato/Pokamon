using UnityEngine;

public interface IRecoger
{
    void Recoger();
}

public interface IRecibirDanoTNT
{
    void DanoPorTnT();
}

public abstract class Bloque : IRecibirDanoTNT
{
    public int id;
    public string nombre;

    public virtual void Colocar()
    {
        Debug.Log("Colocar");
    }

    public void DanoPorTnT()
    {
        Debug.Log("Me dañe");
    }

    public virtual void Romper()
    {
        Debug.Log("Romper");
    }
}

public class BloqueConstruccion : Bloque
{
    public override void Colocar()
    {
        Debug.Log("Colocar Construccion");
    }
    public override void Romper()
    {
        base.Romper();
        Debug.Log("Suelta Item");
    }
}

public class BloqueInteractivo : Bloque, IRecoger
{
    public override void Colocar()
    {
        Debug.Log("Colocar Interactivo");
    }

    public void Recoger()
    {
        Debug.Log("Me guardaron :)");   
    }

    public override void Romper()
    {
        base.Romper();
        Debug.Log("Nada");
    }
    public virtual void Usar()
    {
        Debug.Log("Usar");
    }
}

public class BloqueInteractivoRedstone : BloqueInteractivo
{
    public int CatidadRedstone;

    public override void Usar()
    {
        base.Usar();
        Debug.Log("Usando la Redstone");
    }

    public override void Romper()
    {
        Debug.Log("Particulas de Redstone");
    }

}

public class BloqueInteractivoMesas : BloqueInteractivo
{
    public void Crear()
    {
        Debug.Log("Crear");
    }
}


public class NewBehaviourScript : MonoBehaviour
{
    private void Start()
    {
        Bloque bloqueRedstone = new BloqueInteractivoRedstone();
        bloqueRedstone.Colocar();
        bloqueRedstone.Romper();

        BloqueInteractivoRedstone cambioARedstone = (BloqueInteractivoRedstone) bloqueRedstone;
        cambioARedstone.Colocar();
        cambioARedstone.Usar();
        cambioARedstone.Romper();

        BloqueInteractivoMesas mesaCrafteo = new BloqueInteractivoMesas();
        mesaCrafteo.Usar();

        BloqueInteractivo mesaABloqueInteractivo = mesaCrafteo;
        mesaABloqueInteractivo.Romper();

        Bloque bloqueConstruccion = new BloqueConstruccion();
        Bloque bloqueInteractivo = new BloqueInteractivo();
    }
}