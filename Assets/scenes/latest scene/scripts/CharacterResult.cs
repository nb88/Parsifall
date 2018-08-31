using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class CharacterResult : MonoBehaviour {

    private int resultChar;

    public GameObject ch1;
    public GameObject ch2;
    public GameObject ch3;
    public GameObject ch4;
    public GameObject ch5;
    public GameObject ch6;

    public Text highestIntName;
    public Text lowestIntName;
    public Text charOmschrijving;

    public Transform highChar;
    public Transform lowChar;
    
    public GameObject spawnPointHighest;
    public GameObject spawnPointLowest; 

    
    public int GetTheHighest(int[] allScores, int highestInt)
    {
        highestInt = allScores.Max();
        

        if (allScores[0] == highestInt)
        {
            ch1.transform.position = highChar.position;
            ch1.transform.localScale = new Vector3(100, 100, 0);
            ch1.SetActive(true);
           // highChar.sprite = ch1;
            //spawnPointLowest.GetComponent<Image>().enabled = true;
            spawnPointHighest.SetActive(true);
            resultChar = 1;
            highestIntName.text = "De betrouwbare ";
            charOmschrijving.text = "Stick to the plan!Belofte maakt schuld. Kan en wil hard werken.Vindt geld verdienen belangrijk als basis van zekerheid. Komt beloftes en plichten na.Houdt zich aan wetten en regels en " +
                "protesteert daar niet tegen.Kan goed luisteren en geheimen bewaren. Is niet snel van mening te veranderen.Kan goed plannen en situaties overzien. Heeft graag een vaste baan en een huis. Gebruikt geen drugs " +
                "en drinkt weinig. Vindt dat mensen hun problemen zelf moeten oplossen. Heeft liefst een hond als huisdier. Is niet zo veel online, maar komt wel graag naar een verjaardag of reünie.Vindt familie belangrijk en " +
                "heeft een paar echt goede vrienden. Gaat alleen shoppen voor dingen die je echt nodig hebt.  ";
        }

        if (allScores[1] == highestInt)
        {
            ch2.transform.position = highChar.position;
            ch2.transform.localScale = new Vector3(100, 100, 0);
            ch2.SetActive(true);
            //highCharAni = ch2Ani;
            //highChar.sprite = ch2;       
            spawnPointHighest.SetActive(true);
            resultChar = 2;
            highestIntName.text = "Het Feestbeest ";
            charOmschrijving.text = "Yolo! Waar is het feestje..?! Levensgenieter, is graag het middelpunt. Altijd enthousiast. Zegt nooit nee. Ziet overal de leuke, positieve kanten. Durft risico’s te nemen. Denkt weinig" +
                " na over gevaren en consequenties. Is impulsief. Zorgt dat hij/zij het zelf goed heeft. Gul met tijd en energie en sleept anderen mee. Wil dat het leuk blijft. Houdt niet van verplichtingen en afspraken. Is" +
                " vluchtig in aandacht. Snel en oppervlakkig. Houdt niet van lezen en lang of diep nadenken. Gaat graag shoppen en stappen. Woont in de stad. Ziet social media als plek om party’s en evenementen te delen. Heeft" +
                " geen vaste baan, maar switcht graag. Leert makkelijk, maar is tevreden met zesjes.";
        }

        if (allScores[2] == highestInt)
        {
            ch3.SetActive(true);
            ch3.transform.position = highChar.position;
            ch3.transform.localScale = new Vector3(100, 100, 0);
            //highChar.sprite = ch3;
            spawnPointHighest.SetActive(true);
            resultChar = 3;
            highestIntName.text = "De Idealist ";
            charOmschrijving.text = "Yes, we can! I have a dream! Wereldverbeteraar, probeert draagvlak te creëren om de wereld beter te krijgen. Gaat op de barricades als het moet, spreekt de politiek aan, demonstreert en tekent graag petities. " +
                "Gelooft in verandering, houdt vast aan idealen en probeert anderen te overtuigen. Is bevlogen en heeft een positieve instelling. Heeft veel energie en is actief. Krijgt anderen enthousiast voor eigen ideeën. Woont in energie-neutrale " +
                "woning, aan de rand van de stad. Is op de hoogte van het laatste nieuws. Ziet social media als plek om idealen te delen. Kan goed leren en wil later het liefst voor verschillende maatschappelijke organisaties werken.";
        }

        if (allScores[3] == highestInt)
        {    
            ch4.transform.position = highChar.position;
            ch4.transform.localScale = new Vector3(100, 100, 0);
            ch4.SetActive(true);
            //highChar.sprite = ch4;
            // spawnPointLowest.GetComponent<Image>().enabled = true;
            spawnPointHighest.SetActive(true);
            resultChar = 4;
            highestIntName.text = "De Loner ";
            charOmschrijving.text = "Waar is de nooduitgang?! Is het liefst alleen, trekt zich regelmatig terug uit de maatschappij. Maakt niet snel contact. Is onafhankelijk en trekt zich weinig aan van wat anderen vinden of zeggen. " +
                "Past zich niet aan, aan de heersende norm, maar blijft zichzelf in verschillende situaties. Heeft een kleine groep goeie vrienden. Heeft een heel eigen gevoel voor humor. Houdt niet zo van feestjes en grote groepen mensen. " +
                "Kan goed observeren. Geeft een mening als daarom gevraagd wordt. Kan goed voor zichzelf zorgen en wil later graag zelfvoorzienend leven zoals eigen stroom opwekken of een groentetuin. Houdt van verre reizen en blijft het liefst " +
                "lang weg. Kan lang en diep nadenken. Onderneemt weinig actie en wordt soms door anderen vergeten. Houdt van schilderen, tekenen, of gamen, iets wat je alleen kunt doen. ";
        }

        if (allScores[4] == highestInt)
        {
            ch5.transform.position = highChar.position;
            ch5.transform.localScale = new Vector3(100, 100, 0);
            ch5.SetActive(true);
            //highChar.sprite = ch5;
           // spawnPointLowest.GetComponent<Image>().enabled = true;
            spawnPointHighest.SetActive(true);
            resultChar = 5;
            highestIntName.text = "De Redder ";
            charOmschrijving.text = "Save the world! Is een goeie vriend die er graag voor anderen is. Kan goed luisteren en oplossend denken. Is bereid in te leveren of iets op te offeren, als een ander daar blij van wordt. Heeft altijd tijd, is " +
                "nooit te druk en is flexibel. Is positief en ziet altijd wel mogelijkheden om dingen op te lossen. Kan anderen geruststellen en is rustig als iedereen in paniek raakt. Heeft de neiging om veel te geven en daardoor te weinig aan zichzelf " +
                "te denken. Is goedgelovig en er wordt soms misbruik van hem/haar gemaakt. Heeft een sfeervol warm huis. Kan goed koken. Wil later werken in de sociale sector of onderwijs. Is actief bij clubs als trainer of vrijwilliger op festivals ed. ";
        }

        if (allScores[5] == highestInt)
        {
            ch6.transform.position = highChar.position;
            ch6.transform.localScale = new Vector3(100, 100, 0);
            ch6.SetActive(true);
            //highChar.sprite = ch6;
           // spawnPointLowest.GetComponent<Image>().enabled = true;
            spawnPointHighest.SetActive(true);
            resultChar = 6;
            highestIntName.text = "De rebel ";
            charOmschrijving.text = "Wil zijn eigen keuzes maken. Loopt niet blindelings achter de massa aan. Wil zich niet aanpassen en als dat betekent dat hij alleen staat, nou, dan is dat maar zo. Woont in een kraakpand en heeft hond als huisdier.Gebruikt " +
                "social media om zijn ideeën over de samenleving te delen en om op te roepen tot actie en protest als dat nodig is. Houdt van discussiëren en doet dit graag avonden lang. Komt niet echt tot actie.Wil er niet uitzien zoals iedereen en draagt kleding " +
                "die anders zijn dan de heersende norm";
        }

        return highestInt;
    }

    public int GetTheLowest(int[] allScores, int lowestInt)
    {
        lowestInt = allScores.Min();


        if (allScores[0] == lowestInt)
        {
            ch1.transform.position = lowChar.position;
            ch1.transform.localScale = new Vector3(100, 100, 0);
            ch1.SetActive(true);           
            //lowChar.sprite = ch1;
            //spawnPointLowest.GetComponent<Image>().enabled = true;
            spawnPointLowest.SetActive(true);
            resultChar = 1;
            lowestIntName.text = "De betrouwbare ";
        }

        if (allScores[1] == lowestInt)
        {
            ch2.transform.localScale = new Vector3(100, 100, 0);
            ch2.transform.position = lowChar.position;
            ch2.SetActive(true);
            // lowChar.sprite = ch2;
            //spawnPointLowest.GetComponent<Image>().enabled = true;
            spawnPointLowest.SetActive(true);
            resultChar = 2;
            lowestIntName.text = "Het Feestbeest ";
        }

        if (allScores[2] == lowestInt)
        {
            ch3.transform.localScale = new Vector3(100, 100, 0);
            ch3.transform.position = lowChar.position;
            ch3.SetActive(true);     
            //   lowChar.sprite = ch3;
            //spawnPointLowest.GetComponent<Image>().enabled = true;
            spawnPointLowest.SetActive(true);
            resultChar = 3;
            lowestIntName.text = "De Idealist ";
        }

        if (allScores[3] == lowestInt)
        {
            ch4.transform.localScale = new Vector3(100, 100, 0);
            ch4.transform.position = lowChar.position;
            ch4.SetActive(true);
            // lowChar.sprite = ch4;
            //spawnPointLowest.GetComponent<Image>().enabled = true;
            spawnPointLowest.SetActive(true);
            resultChar = 4;
            lowestIntName.text = "De Loner ";
        }

        if (allScores[4] == lowestInt)
        {
            ch5.transform.localScale = new Vector3(100, 100, 0);
            ch5.transform.position = lowChar.position;
            ch5.SetActive(true);
            // lowChar.sprite = ch5;
            //spawnPointLowest.GetComponent<Image>().enabled = true;
            spawnPointLowest.SetActive(true);
            resultChar = 5;
            lowestIntName.text = "De Redder ";
        }

        if (allScores[5] == lowestInt)
        {
            ch6.transform.localScale = new Vector3(100, 100, 0);
            ch6.transform.position = lowChar.position;
            ch6.SetActive(true);
            //lowChar.sprite = ch6;
            //spawnPointLowest.GetComponent<Image>().enabled = true;
            spawnPointLowest.SetActive(true);
            resultChar = 6;
            lowestIntName.text = "De rebel ";
        }

        return lowestInt;
    }
}
