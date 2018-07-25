using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class CharacterResult : MonoBehaviour {

    public Sprite ch1;
    public Sprite ch2;
    public Sprite ch3;
    public Sprite ch4;
    public Sprite ch5;
    public Sprite ch6;

    public Text highestIntName;
    public Text lowestIntName;

    public GameObject spawnPointHighest;
    public GameObject spawnPointLowest;
  

    //public Textvieuw tv;
    public Text charOmschrijving;

    private int resultChar;


    public int GetTheHighest(int[] allScores, int highestInt)
    {
        highestInt = allScores.Max();
        Debug.Log(highestInt);
        

        if (allScores[0] == highestInt)
        {
            Debug.Log("character one has the most points");
            spawnPointLowest.GetComponent<Image>().enabled = true;
            spawnPointHighest.SetActive(true);
            resultChar = 1;
            highestIntName.text = "De betrouwbare ";
            charOmschrijving.text = "Stick to the plan! Belofte maakt schuld. Kan en wil hard werken. Vindt geld verdienen belangrijk als basis van zekerheid.Komt beloftes en plichten na.Houdt zich aan wetten " +
                "en regels en is niet geneigd daartegen te protesteren.Kan goed luisteren en geheimen bewaren. Is niet snel van mening te veranderen.Kan goed plannen en situaties overzien. Wil liever een vaste " +
                "baan en een gewoon rijtjeshuis.Gebruikt geen drugs en drinkt weinig. Vindt dat mensen hun problemen zelf moeten oplossen.Heeft liefst een hond als huisdier. Is niet zo veel online, maar komt wel" +
                " graag naar een verjaardag of reünie.Vindt familie belangrijk en heeft een paar echt goede vrienden. Gaat alleen shoppen voor dingen die je echt nodig hebt. Is niet extreem goed in leren, maar " +
                "haalt wel voldoendes. ";
        }

        if (allScores[1] == highestInt)
        {
            Debug.Log("character two has the most points");
            spawnPointHighest.GetComponent<Image>().sprite = ch2;       
            spawnPointHighest.SetActive(true);
            resultChar = 2;
            highestIntName.text = "Het Feestbeest ";
            charOmschrijving.text = " Yolo! Waar is het feestje..?! Levensgenieter, is graag het middelpunt. Altijd enthousiast. Zegt nooit nee.Ziet overal de leuke, positieve kanten.Durft risico’s te nemen.Denkt " +
                "weinig na over gevaren en consequenties.Is impulsief. Zorgt dat hij / zij het zelf goed heeft. Gul met tijd en energie en sleept anderen mee.Wil dat het leuk blijft.Houdt van een feestje!Houdt niet " +
                "van verplichtingen en afspraken.Is vluchtig in aandacht.Snel en oppervlakkig.Houdt niet van lezen en lang of diep nadenken.Houdt niet van wandelen in de natuur. Gaat graag shoppen en stappen." +
                "Woont in de stad. Ziet social media als plek om party’s en evenementen te delen.Heeft een kat als huisdier.Heeft geen vaste baan, maar switcht graag en leert makkelijk, maar is tevreden met 6 - jes.";
        }

        if (allScores[2] == highestInt)
        {
            Debug.Log("character three has the most points");
            spawnPointHighest.GetComponent<Image>().sprite = ch3;
            spawnPointHighest.SetActive(true);
            resultChar = 3;
            highestIntName.text = "De Idealist ";
            charOmschrijving.text = "Yes, we can!I have a dream!Wereldverbeteraar, probeert draagvlak te creëren om de wereld beter te krijgen. Gaat op de barricades als het moet, spreekt de politiek aan, demonstreert " +
                "en tekent graag petities.Gelooft in verandering, houdt vast aan idealen en probeert anderen te overtuigen.Is bevlogen en heeft een positieve instelling.Heeft veel energie en is actief.Krijgt anderen " +
                "enthousiast voor eigen ideeën. Woont in energie - neutrale woning, aan de rand van de stad. Leest de krant en is op de hoogte van het laatste nieuws.Ziet social media als plek om idealen te delen. Heeft " +
                "uit principe geen huisdieren, maar vangt ze wel op als dat nodig is.Kan goed leren en wil later het liefst voor verschillende maatschappelijke organisaties werken.";
        }

        if (allScores[3] == highestInt)
        {
            Debug.Log("character four has the most points");
            spawnPointHighest.GetComponent<Image>().sprite = ch4;
            spawnPointLowest.GetComponent<Image>().enabled = true;
            spawnPointHighest.SetActive(true);
            resultChar = 4;
            highestIntName.text = "De Loner ";
            charOmschrijving.text = "Waar is de nooduitgang?! Is het liefst alleen, trekt zich regelmatig terug uit de maatschappij. Maakt niet snel of makkelijk contact.Is onafhankelijk en trekt zich weinig aan van wat " +
                "anderen vinden of zeggen.Past zich niet aan, aan de heersende norm, maar blijft zichzelf in verschillende situaties. Heeft een kleine groep hele goeie vrienden.Heeft een heel eigen gevoel voor humor.Houdt " +
                "niet zo van feestjes en grote groepen mensen.Kan goed observeren.Geeft een mening als daarom gevraagd wordt.Kan goed voor zichzelf zorgen en wil later graag zelfvoorzienend leven zoals eigen stroom opwekken " +
                "of een groentetuin. Houdt van wandelen, lezen, museumbezoek ed. Houdt van verre reizen en blijft het liefst lang weg. Houdt een dagboek bij wat niemand mag lezen. Kan lang en diep nadenken.Onderneemt weinig " +
                "actie en wordt soms door anderen vergeten.Heeft liever geen huisdieren, maar als het moet een schildpad of vissen.Houdt van schilderen, tekenen, of iets maken / knutselen.Is niet actief op social media.";
        }

        if (allScores[4] == highestInt)
        {
            Debug.Log("character five has the most points");
            spawnPointHighest.GetComponent<Image>().sprite = ch5;
            spawnPointLowest.GetComponent<Image>().enabled = true;
            spawnPointHighest.SetActive(true);
            resultChar = 5;
            highestIntName.text = "De Redder ";
            charOmschrijving.text = "Save the world! Is een goeie vriend die er graag voor anderen is. Kan goed luisteren en oplossend denken.Wordt aangetrokken door hulpzoekenden en voelt zich beter door anderen te helpen. " +
                "Is bereid in te leveren of iets op te offeren, als een ander daar blij van wordt.Heeft altijd tijd, is nooit te druk en is flexibel.Is positief en ziet altijd wel mogelijkheden om dingen op te lossen. Kan anderen " +
                "geruststellen en is rustig als iedereen in paniek raakt. Heeft de neiging om veel te geven en daardoor te weinig aan zichzelf te denken.Is goedgelovig en er wordt soms misbruik van hem / haar gemaakt. Heeft een sfeervol" +
                " warm huis met een slaapkamer extra.Kan goed koken.Heeft veel planten en vangt huisdieren op of werkt in een asiel. Wil later werken in de sociale sector of onderwijs.Is actief bij clubs als trainer of vrijwilliger op festivals ed.";
        }

        if (allScores[5] == highestInt)
        {
            Debug.Log("character six has the most points");
            spawnPointHighest.GetComponent<Image>().sprite = ch6;
            spawnPointLowest.GetComponent<Image>().enabled = true;
            spawnPointHighest.SetActive(true);
            resultChar = 6;
            highestIntName.text = "De rebel ";
            charOmschrijving.text = "Wil zijn eigen keuzes maken. Loopt niet blindelings achter de massa aan. Wil zich niet aanpassen en als dat betekend dat hij alleen staat, nou, dan is dat maar zo.Houd er niet van dat iemand de baas over hem is. " +
                "Vindt vrijheid belangrijk zowel voor zichzelf als voor anderen. Heeft als ideaal een samenleving waarin niemand de leiding heeft en je met elkaar voor elkaar zorgt.Heeft oog voor mensen die het minder goed hebben en wil ze graag helpen. " +
                "Woont in een kraakpand en heeft hond als huisdier.Gebruikt social media om zijn idealistische ideeën over de samenleving te delen en om op te roepen tot actie en protest als dat nodig is.Houdt van discussiëren en doet dit graag avonden lang. " +
                "Wil er niet uitzien zoals iedereen en draagt kleding die anders zijn dan de heersende norm.";
        }

        return highestInt;
    }

    public int GetTheLowest(int[] allScores, int lowestInt)
    {
        lowestInt = allScores.Min();
        Debug.Log(lowestInt);


        if (allScores[0] == lowestInt)
        {
            Debug.Log("character one has the most points");
            spawnPointLowest.GetComponent<Image>().sprite = ch1;
            spawnPointLowest.GetComponent<Image>().enabled = true;
            spawnPointLowest.SetActive(true);
            resultChar = 1;
            lowestIntName.text = "De betrouwbare ";
        }

        if (allScores[1] == lowestInt)
        {
            Debug.Log("character two has the most points");
            spawnPointLowest.GetComponent<Image>().sprite = ch2;
            spawnPointLowest.GetComponent<Image>().enabled = true;
            spawnPointLowest.SetActive(true);
            resultChar = 2;
            lowestIntName.text = "Het Feestbeest ";
        }

        if (allScores[2] == lowestInt)
        {
            Debug.Log("character three has the most points");
            spawnPointLowest.GetComponent<Image>().sprite = ch3;
            spawnPointLowest.GetComponent<Image>().enabled = true;
            spawnPointLowest.SetActive(true);
            resultChar = 3;
            lowestIntName.text = "De Idealist ";
        }

        if (allScores[3] == lowestInt)
        {
            Debug.Log("character four has the most points");
            spawnPointLowest.GetComponent<Image>().sprite = ch4;
            spawnPointLowest.GetComponent<Image>().enabled = true;
            spawnPointLowest.SetActive(true);
            resultChar = 4;
            lowestIntName.text = "De Loner ";
        }

        if (allScores[4] == lowestInt)
        {
            Debug.Log("character five has the most points");
            spawnPointLowest.GetComponent<Image>().sprite = ch5;
            spawnPointLowest.GetComponent<Image>().enabled = true;
            spawnPointLowest.SetActive(true);
            resultChar = 5;
            lowestIntName.text = "De Redder ";
        }

        if (allScores[5] == lowestInt)
        {
            Debug.Log("character six has the most points");
            spawnPointLowest.GetComponent<Image>().sprite = ch6;
            spawnPointLowest.GetComponent<Image>().enabled = true;
            spawnPointLowest.SetActive(true);
            resultChar = 6;
            lowestIntName.text = "De rebel ";
        }

        return lowestInt;
    }
}
