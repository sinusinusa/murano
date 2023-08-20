using DataLayer.Entityes;

namespace murano.logic;

public interface Searcher
{
  public string ApiKey { get; set; }
  public List<Result> GetResults(string request);
}