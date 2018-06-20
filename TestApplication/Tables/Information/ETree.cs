using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Collections;
using System;

namespace TestApplication
{
    public class ETree : IEnumerable<ETree>
    {
        public ListWithName Line { get; set; }
        public IEnumerator<ETree> GetEnumerator()
        {
            if (Line == null)
                return ERepository.table.Select(node => new ETree() { Line = node }).GetEnumerator();
            string id = Line.SubItems[0];
            return ERepository.table.Where(node => node.SubItems[5] == id).Select(node => new ETree() { Line = node }).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public override bool Equals(object obj)
        {
            var other = obj as ETree;
            if (other == null) return false;
            if (Line == other.Line) return true;
            return Line.SubItems[0] == other.Line.SubItems[0];
        }
        public static bool IsDescendant(ETree parent, ETree descendant)
        {
            if (parent.Contains(descendant))
                return true;
            foreach (ETree child in parent)
            {
                if (child.Contains(descendant))
                    return true;

                else if (child.Any())
                    return IsDescendant(child, descendant);
                else
                    continue;
            }
            return false;
        }
        public override int GetHashCode()
        {
            if (Line == null) return 0;
            return int.Parse(Line.SubItems[0]);
        }

        public override string ToString()
        {
            if (Line == null) return "";
            return Line.SubItems[1];
        }
        public DateTime Date()
        {
            if (Line == null) return DateTime.Now;
            return DateTime.Parse(Line.SubItems[2]);
        }
        public string Post()
        {
            if (Line == null) return "";
            return Line.SubItems[3];
        }
        public int Salary()
        {
            if (Line == null) return 0;
            return int.Parse(Line.SubItems[4]);
        }
        public int Subordinate()
        {
            if (Line == null) return 0;
            return int.Parse(Line.SubItems[5]);
        }
    }
}
