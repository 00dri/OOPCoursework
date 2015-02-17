using System;
using System.Collections;
using System.Text;

namespace StringDisperser
{
    public class StringDisperser : ICloneable, IComparable<StringDisperser> ,IEnumerable
    {
        private StringBuilder text = new StringBuilder();

        public StringDisperser(params string[] input)
        {
            foreach (var element in input)
            {
                this.Text.Append(element);
            }
        }

        public StringBuilder Text
        {
            get { return text; }
            set { text = value; }
        }

        public override bool Equals(object obj)
        {
            var disperser = obj as StringDisperser;
            return disperser != null && this.Text.ToString().Equals(disperser.ToString());
        }

        public override int GetHashCode()
        {
            const int hashMultiple = 31;
            return this.Text.GetHashCode() * hashMultiple;
        }

        public override string ToString()
        {
            return this.Text.ToString();
        }

        public object Clone()
        {
            return new StringDisperser(this.Text.ToString());
        }

        public int CompareTo(StringDisperser other)
        {
            return String.Compare(this.Text.ToString(), other.Text.ToString(), StringComparison.Ordinal);
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < this.Text.Length; i++)
            {
                yield return this.Text[i];
            }
        }
    }
}
