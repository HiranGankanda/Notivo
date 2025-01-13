using System.Text.RegularExpressions;

namespace Notivo.Core.Domain.ValueObjects
{
    public class Email
    {
        private static readonly Regex EmailRegex =
            new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);

        public string Value { get; private set; }

        public Email(string value)
        {
            if (!EmailRegex.IsMatch(value))
                throw new ArgumentException("Invalid email format.");

            Value = value;
        }

        public override string ToString() => Value;

        public override bool Equals(object obj) =>
            obj is Email email && Value == email.Value;

        public override int GetHashCode() => Value.GetHashCode();
    }
}