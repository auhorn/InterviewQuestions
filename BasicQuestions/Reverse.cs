using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQuestions {
  public class Reverse {

    /// <summary>
    /// Reverse each word in a string and returns the sentence as a string.
    /// </summary>
    /// <remarks>
    /// This is the straight forward solution
    /// </remarks>
    /// <param name="sentence">sentence to be reversed</param>
    /// <returns>reversed sentence</returns>
    public static string ReverseSentence(string sentence){

      if (string.IsNullOrEmpty( sentence )) { throw new ArgumentNullException("sentence", "Sentence to reverse cannot be null or empty");}
      
      string _reversedSentence = string.Empty;
      StringBuilder _sb = new StringBuilder();

      var _parts = sentence.Split( ' ' );

      for (int i = _parts.Length - 1 ; i >= 0; i--) {
        _sb.AppendFormat( "{0} ", _parts[i] );
      }

      // remove the last space
      _reversedSentence = _sb.Remove(_sb.Length-1, 1).ToString();

      return _reversedSentence;
    }

    /// <summary>
    /// Reverse each word in a string and returns the sentence as a string.
    /// </summary>
    /// <remarks>
    /// This is the LINQ solution
    /// </remarks>
    /// <param name="sentence">sentence to be reversed</param>
    /// <returns>reversed sentence</returns>
    public static string ReverseSentenceLinq( string sentence ) {
      if (string.IsNullOrEmpty( sentence )) { throw new ArgumentNullException( "sentence", "Sentence to reverse cannot be null or empty" ); }
      
      return sentence.Split( ' ' ).Reverse().Aggregate( ( i, j ) => i + " " + j );
    }
  }
}
