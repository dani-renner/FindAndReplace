namespace FindReplace.Models{

  public class Finder
  {
    public string FullQuote{get;set;}
    public string StringToReplace{get;set;}
    public string StringReplaceWith{ get; set; }

    public Finder(string fullquote,string stringtoreplace,string stringreplacewith)
    {
      FullQuote = fullquote;
      StringToReplace = stringtoreplace;
      StringReplaceWith = stringreplacewith;
      
    }

    public string FindandReplace()
    {
      int index = 0;
      string CapQuote = FullQuote.ToUpper();
      string CapString = StringToReplace.ToUpper();
      while(CapQuote.Contains(CapString))
      {
        index = CapQuote.IndexOf(CapString);
        CapQuote.Remove(index,CapString.Length);
        CapQuote.Insert(index,StringReplaceWith);

        FullQuote.Remove(index,CapString.Length);
        FullQuote.Insert(index,StringReplaceWith);
      }

      // FullQuote.Replace(StringToReplace,StringReplaceWith);
      return FullQuote;
    }
  }
}