using System.Text.RegularExpressions;

namespace TestDomeKatas
{
    /// <summary>
    /// Replace all occurrences of XXX-YY-ZZZZ with XXX/YY/ZZZZ
    /// </summary>
    public class ParagraphKata
    {
        private const string Separator = @"/";
        private const string Expression = @"\d{3}-\d{2}-\d{4}";

        private static readonly Regex Regex = new Regex(Expression, RegexOptions.Compiled);

        public static string ChangeFormat(string paragraph)
        {
            return Regex.Replace(paragraph, match =>
            {
                var found = match.ToString();
                var parts = found.Split('-');
                return $@"{parts[0]}{Separator}{parts[2]}{Separator}{parts[1]}";
            });
        }
    }
}
