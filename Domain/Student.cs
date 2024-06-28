using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class Student
    {
        public Student(User user, Level level, DateTime startDate)
        {
            User = user ?? throw new ArgumentNullException(nameof(user));
            Level = level;
            StartDate = startDate;
        }

        public User User { get; private set; }
        public Level Level { get; private set; }
        public DateTime StartDate { get; }

        public void ChangeLevel(Level nextLevel)
        {
            if (nextLevel == Level)
                throw new InvalidOperationException($"Change {Level.Name} to {nextLevel.Name} is not possible.");

            Level = nextLevel;
        }
    }
}
