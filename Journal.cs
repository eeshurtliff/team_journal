public class EesJournal{
    public List<EesEntry> _eesEntry = new List<EesEntry>();

    public void DisplayJournal(){
        
        foreach (EesEntry eesSingleEntry in _eesEntry){
            eesSingleEntry.EesDisplayCompleteEntry();
        }
    }

    
}
