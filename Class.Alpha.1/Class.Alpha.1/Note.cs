using System.Collections.Generic;

namespace Class.Alpha._1
{
    public class Note
    {
        private Paragraph _paragraph;
        private List<Sentence> _sentences;
        private int _start, _end;
        private string oTime, cTime, note, name;
        public Note()
        {
            
        }

        public void GetFromServer()
        {
            
        }
        
        public void SetNecessaryParagraphProperties(List<Sentence> sentences, int start, int end)
        {
            _paragraph = new Paragraph(sentences,start,end);
        }

        public Paragraph Paragraph => _paragraph;
    }

    public class Paragraph
    {
        private int _start, _end;
        private List<Sentence> _sentences;
        
        public Paragraph()
        {
            
        }
        
        /// <summary>
        /// Initialize of Paragraph class
        /// </summary>
        /// <param name="sentences">Whole sentences</param>
        /// <param name="start">Start index of sentences</param>
        /// <param name="end">End index of sentences</param>
        public Paragraph(List<Sentence> sentences, int start, int end)
        {
            _sentences = sentences;
            _start = start;
            _end = end;
        }

        /// <summary>
        /// Get sentences in range (start, end)
        /// </summary>
        /// <returns>Sentences</returns>
        public List<Sentence> GetSentences()
        {
            var ret = new List<Sentence>();
            for (var i = _start; i <= _end; i++)
            {
                ret.Add(_sentences[i]);
            }

            return ret;
        }

        /// <summary>
        /// Expand sentences to right.
        /// </summary>
        /// <returns>Whether done successful</returns>
        public bool RightExpand()
        {
            if ((_end + 1) > _sentences.Count)
            {
                return false;
            }

            _end++;
            return true;
        }

        /// <summary>
        /// Expand sentences to left.
        /// </summary>
        /// <returns>Whether done successful</returns>
        public bool LeftExpand()
        {
            if ((_start - 1) < 0)
            {
                return false;
            }

            _start--;
            return true;
        }
    }
    
    public struct Sentence
    {
        public int StartTime;
        public int EndTime;
        public string Text;
    }
    
}