namespace CodeToCode.Services
{
    public interface ICodeConverterService
    {
        string ConvertCode(string currentLanguage, string newLanguage, string code);
    }
}