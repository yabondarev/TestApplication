using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Collections;


namespace TestApplication
{
    class LItem : IEnumerable<LItem>
    {
        public ListWithName Line { get; set; }
        public IEnumerator<LItem> GetEnumerator()
        {
            if (Line == null)
                return LRepository.table.Select(item => new LItem() { Line = item }).GetEnumerator();
            int id = int.Parse(Line.SubItems[0]);
            return LRepository.table.Where(item => int.Parse(item.SubItems[0]) > id).Select(item => new LItem() { Line = item }).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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
        public string Password()
        {
            if (Line == null) return "";
            return Line.SubItems[2];
        }
    }
}
