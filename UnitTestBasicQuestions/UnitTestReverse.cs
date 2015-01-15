using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicQuestions;

namespace UnitTestBasicQuestions {
  [TestClass]
  public class UnitTestReverse {

    static string SourceSentence = "The quick brown fox jumps over the lazy dog";

    static string ExpectedSentence = "dog lazy the over jumps fox brown quick The";

    public void ReverseTests (Func<string, string> reverseFunction, string reverseFunctionDescription){
      string _actual = string.Empty;

      // check if the reverse is working
      _actual = reverseFunction( SourceSentence );
      Assert.AreEqual( ExpectedSentence, _actual,"Reverse not correct for <{0}>", reverseFunctionDescription);

      // check on null parameter 
      try {
        _actual = reverseFunction( null );
      }
      catch (ArgumentNullException) {
       // this is correct
      }
      catch (Exception _exception) {
        Assert.Fail( "Null exception not correct for <{0}>. Exception <{1}>", reverseFunctionDescription, _exception );
      }

      // check on empty parameter
      try {
        _actual = reverseFunction( string.Empty);
      }
      catch (ArgumentNullException) {
        // this is correct
      }
      catch (Exception _exception) {
        Assert.Fail( "Empty exception not correct for <{0}>. Exception <{1}>", reverseFunctionDescription, _exception );
      }


    }


    [TestMethod]
    public void ReverseSentence() {
      ReverseTests( Reverse.ReverseSentence, "Straight Forward: ReverseSentence" );
    }

    [TestMethod]
    public void ReverseSentenceUsingLinq() {
      ReverseTests( Reverse.ReverseSentenceLinq, "Using Linq: ReverseSentenceLinq" );
    }


  }
}
