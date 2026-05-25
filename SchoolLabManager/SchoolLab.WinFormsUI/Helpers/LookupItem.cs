namespace SchoolLab.WinFormsUI.Helpers
{
    public class LookupItem
    {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public override string ToString() => Name;
    }
}
