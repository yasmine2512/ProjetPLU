using System.Net.Http;
using System.Threading.Tasks;

public class SummarizeService
{
    private readonly HttpClient _httpClient;

    public SummarizeService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> SummarizeThesisAsync(int memoireId, string filePath)
    {
        // Construct API endpoint for summary
        var response = await _httpClient.PostAsJsonAsync("api/theses/summarize", new { MemoireID = memoireId, FilePath = filePath });

        if (response.IsSuccessStatusCode)
        {
            var summary = await response.Content.ReadAsStringAsync();
            return summary;
        }
        else
        {
            return "Erreur lors du résumé.";
        }
    }
}
