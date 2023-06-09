namespace abp_7_2_2.Maui.Storage;

public interface IStorage
{
    Task<string> GetAsync(string key);

    Task SetAsync(string key, string value);

    Task RemoveAsync(string key);
}