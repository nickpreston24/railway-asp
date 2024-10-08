using System.Text.RegularExpressions;

public class RegexEnumBase : Enumeration
{
    protected RegexEnumBase(int id, string name, string pattern, string uri = "")
        : base(id, name)
    {
        Pattern = pattern;
        CompiledRegex = new System.Text.RegularExpressions.Regex(
            pattern,
            RegexOptions.Compiled | RegexOptions.IgnoreCase
        );
        this.uri = uri;
    }

    public string uri { get; set; } = string.Empty;

    public Regex CompiledRegex { get; set; }
    public string Pattern { get; set; }
}
