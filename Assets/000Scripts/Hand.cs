using UnityEngine;

public class Hand : MonoBehaviour
{
    //le nombre de doigt dans la main
    [field: SerializeField] private int NombreDeDoigts = 3;
    //la distance entre les deux doigts les plus éloignés
    [field: SerializeField] private float Largeur = 50f;
    //le prefab d'un doigt
    [field: SerializeField] private GameObject DoigtPrefab;

    //la pioche
    [field: SerializeField] private Pioche Pioche;

    //la liste des tuiles de la main
    private Tuile[] ListOfTuiles;
    //la tuile selectionnée
    public Tuile SelectedTuile { get; set; }

    void Start()
    {
        SpawnDoigts();
        Refill();
    }

    private void SpawnDoigts()
    {
        ListOfTuiles = new Tuile[NombreDeDoigts];

        float step = Largeur / NombreDeDoigts;
        Vector3 position = new Vector3(6, 0, - step * (NombreDeDoigts - 1) / 2);

        for (int index = 0; index < NombreDeDoigts; ++index)
        {
            Instantiate(DoigtPrefab, position, Quaternion.identity);
            position.z += step;
        }
    }

    private void Refill()
    {
        float step = Largeur / NombreDeDoigts;
        Vector3 position = new Vector3(6, 1.2f, -step * (NombreDeDoigts - 1) / 2);

        for (int index = 0; index < NombreDeDoigts; index++)
        {
            ListOfTuiles[index] = Pioche.RandomTuile();
            var tuile = Instantiate(ListOfTuiles[index].gameObject, position, Quaternion.identity).GetComponent<Tuile>();
            tuile.Hand = this;
            tuile.IsInHand = true;

            position.z += step;
        }
    }
}
