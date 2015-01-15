using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Katas;


namespace UnitTestKatas {
  [TestClass]
  public class FizzBuzzTest {

    // create some test data
    List<Tuple<int, string>> TestData = new List<Tuple<int, string>>{
        Tuple.Create (1, "1"),
        Tuple.Create (2, "2"),
        Tuple.Create (3, "fizz"),
        Tuple.Create (4, "4"),
        Tuple.Create (5, "buzz"),
        Tuple.Create (6, "fizz"),
        Tuple.Create (7, "7"),
        Tuple.Create (8, "8"),
        Tuple.Create (9, "fizz"),
        Tuple.Create (10, "buzz"),
        Tuple.Create (11, "11"),
        Tuple.Create (12, "fizz"),
        Tuple.Create (13, "13"),
        Tuple.Create (14, "14"),
        Tuple.Create (15, "fizzbuzz"),
        Tuple.Create (16, "16"),
        Tuple.Create (17, "17"),
        Tuple.Create (18, "fizz"),
        Tuple.Create (19, "19"),
        Tuple.Create (20, "buzz")
      };


    /// <summary>
    /// Test if the "calculation" is correct.
    /// </summary>
    [TestMethod]
    public void FizzBuzzCalculation() {
      var _FB = new FizzBuzz();

      // test the function itself and see 
      foreach(var item in TestData) {
        Assert.AreEqual( item.Item2, _FB.Answer( item.Item1 ) );
      }

    }

    /// <summary>
    /// Check if the iterator is correct
    /// </summary>
    [TestMethod]
    public void FizzBuzzIterator(){
      var _FB = new FizzBuzz();
      foreach(var item in _FB.Answers( TestData.Select( x => x.Item1 ) )) {
        var _expected = TestData.First( x => x.Item1 == item.Item1 ).Item2;
        Assert.AreEqual( _expected , item.Item2 );
      }


    }

    /// <summary>
    /// Check if the argument exceptions are properly thrown.
    /// </summary>
    [TestMethod]
    public void FizzBuzzArgumentException() {

      var _FB = new FizzBuzz();

      // check for a 0 
      try {
        var _answer = _FB.Answer( 0 );
      }
      catch(ArgumentOutOfRangeException) { }
      catch(Exception _exception) {
        Assert.Fail( "Got exception <{0}>", _exception.ToString() );
      }


    }
  }

}
;