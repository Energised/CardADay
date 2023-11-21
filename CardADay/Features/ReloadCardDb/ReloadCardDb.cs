using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace CardADay.Features.ReloadCardDb;

public class ReloadCardDb
{
    private readonly string _cardUrl = "https://mtgjson.com/api/v5/AllPrintings.json";
    private readonly string _fileName = "allPrintingsData.json";
    
    public async Task GetAndSaveJsonData()
    {
        // TODO: Check metadata of JSON file, only update if its older than 1 week to avoid constant downloads
        using var httpClient = new HttpClient();
        var response = await httpClient.GetAsync(_cardUrl);
        if (response.IsSuccessStatusCode)
        {
            var stream = await response.Content.ReadAsStreamAsync();
            var fileInfo = new FileInfo(_fileName);
            using (var fileStream = fileInfo.OpenWrite())
            {
                await stream.CopyToAsync(fileStream);
            }
        }
        else
        {
            throw new Exception("Request failed");
        }
    }
}