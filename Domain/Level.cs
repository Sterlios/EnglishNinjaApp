using System.Diagnostics.CodeAnalysis;

namespace Domain
{
    public readonly struct Level
    {
        public Level(int id, string name, string shortName)
        {
            Id = id;
            Name = name;
            ShortName = shortName;
        }

        public int Id { get; }
        public string Name { get; }
        public string ShortName { get; }

        public static bool operator ==(Level level1, Level level2) =>
            level1.Id == level2.Id;

        public static bool operator !=(Level level1, Level level2) =>
            level1.Id != level2.Id;

        public override readonly bool Equals([NotNullWhen(true)] object? obj) =>
            obj is Level level && (level).Id == Id;

        public override int GetHashCode() => 
            HashCode.Combine(Id, Name, ShortName);
    }
}