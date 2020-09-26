namespace Arinsys.Components.AspNetCore.Themes
{
    public interface ITheme
    {
        string StaticAssetsPath { get; }
        string AssemblyName { get; }
    }
}
