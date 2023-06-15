using System.Collections.Generic;
using UnityEngine;

public class Emplacement : MonoBehaviour
{
    //le type d'emplacement
    [field: SerializeField] public string Type = "DefaultEmplacementType";
    //la liste des voisins de cet emplacement
    public List<Emplacement> ListeDesVoisins = new List<Emplacement>();
    //la tuile à cet emplacement
    public Tuile Tuile { get; set; }
    //le score de cet emplacement
    public int Score { get; set; } = 0;

    //la main
    [field:SerializeField] private Hand _hand;
    //le score total
    [field: SerializeField] private Score ScoreTotal;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Emplacement emplacement))
        {
            ListeDesVoisins.Add(emplacement);
        }
    }

    private void OnMouseDown()
    {
        if (_hand.SelectedTuile != null)
        {
            if (Tuile == null)
            {
                //gestion de la tuile
                Tuile = _hand.SelectedTuile;
                _hand.SelectedTuile.gameObject.transform.position = transform.position + new Vector3(0, 1.2f ,0);
                _hand.SelectedTuile.gameObject.transform.rotation = transform.rotation;
                _hand.SelectedTuile.IsInHand = false;
                _hand.SelectedTuile = null;
                //gestion du score
                CalculateScore();
                ScoreTotal.ListeDesEmplacementsOccupes.Add(this);
                ScoreTotal.UpdateScore();
            }
        }
    }

    private void CalculateScore()
    {
        //calcul de la valeur
        switch (Tuile.Nom)
        {
            case "Habitant":
                Tuile.Valeur = 1;
                break;
            case "Agriculteur":
                Tuile.Valeur = 0;
                break;
            case "Bucheron":
                Tuile.Valeur = 2 * NombreForetsVoisines();
                break;
        }
        //calcul du score
        Score = Tuile.Valeur + Tuile.NiveauFusion * Tuile.NiveauUpgrade;
    }

    private int NombreForetsVoisines()
    {
        int nombreForetVoisines = 0;

        foreach (Emplacement voisin in ListeDesVoisins)
        {
            if (voisin.Type == "Foret")
            {
                nombreForetVoisines++;
            }
        }
        Debug.Log(nombreForetVoisines);
        return nombreForetVoisines;
    }
}
