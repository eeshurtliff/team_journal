public class EesJournal{
    public List<EesEntry> _eesEntry = new List<EesEntry>();

    public void DisplayJournal(){
        
        foreach (EesEntry eesSingleEntry in _eesEntry){
            eesSingleEntry.EesDisplayCompleteEntry();
        }
    }

    public string FormatJournal(){
        string fullJournal = "";
        foreach (EesEntry eesSingleEntry in _eesEntry){
            fullJournal = $"{fullJournal} \n {eesSingleEntry.EesCompleteEntry()}";
        }
            fullJournal = $"{fullJournal} \n";
            return fullJournal;


         
    }

    
}
