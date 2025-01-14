
namespace pacstore;

public struct Package
{
    public string Name = "";
    public string Pkname = "";
    public string Version = "";
    public string Maintainer = "";
    public string Description = "";
    public string Architecture = "";
    public bool NeedUpdate = false;
    public bool IsInstalled = false;

    public Package()
    {

    }
}
