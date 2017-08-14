using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wManager;
using wManager.Wow.Class;

namespace QuestTest
{
    public sealed class QuestTest : QuestClass // Inheritance of QuestGathererClass
    {
        public QuestTest()
        {
            QuestId.Add(5545); // Add quest id
        }
    }
}
